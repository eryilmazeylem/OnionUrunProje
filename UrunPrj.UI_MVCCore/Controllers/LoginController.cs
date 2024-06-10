using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UrunPrj.Application.Models.DTOs.Login;
using UrunPrj.Application.Models.ViewModels.Login;
using UrunPrj.Application.Services.UserService;
using UrunPrj.Domain.Models;

namespace UrunPrj.UI_MVCCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        private readonly SignInManager<Uye> _signInManager;
        private readonly IMapper _mapper;

        public LoginController(IUserService userService, SignInManager<Uye> signInManager, IMapper mapper)
        {
            _userService = userService;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Index(Login_VM login)
        {
            if (ModelState.IsValid) 
            {

                Login_DTO loginDTO = new Login_DTO();
                _mapper.Map(login, loginDTO);

               Uye uye= _userService.Login(loginDTO, out bool adminMi).Result;
              
                if (uye==null)
                    ModelState.AddModelError("HATA", "Kullanici adi veya sifre yanlis...");
                else
                {
                    //Uye var ise sign-in olmalı
                   await _signInManager.SignInAsync(uye, true);

                    if (adminMi)
                        return Redirect("~/AdminPanel/Panel/Index");
                    else
                        return Redirect("~/UyePanel/Panel/Index");
                }
               
            }
            
            return View(login);
        }

        public IActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> UyeEkle(UyeEkle_VM uye)
        {
            if (ModelState.IsValid)
            {
                UyeEkle_DTO uyeEkle_DTO = new UyeEkle_DTO();
                _mapper.Map(uye,uyeEkle_DTO);

               await _userService.YeniUyeEkleAsync(uyeEkle_DTO);
                return RedirectToAction("Index","Login");
            }
            return View(uye);
        }

        public async Task< IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
