
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Login;
using UrunPrj.Domain.Models;

namespace UrunPrj.Application.Services.UserService
{
    public class UserService : IUserService
    {

        private readonly UserManager<Uye> _userManager;
        //private readonly SignInManager<Uye> _signInManager;

        private readonly IMapper _mapper;

        public UserService(UserManager<Uye> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }


        public int GetUserID(ClaimsPrincipal principal)
        {
            return int.Parse(_userManager.GetUserId(principal));
        }

        public  Task<Uye> Login(Login_DTO login, out bool AdminMi)
        {
            AdminMi = false;
            var uye =  _userManager.FindByEmailAsync(login.EPosta).Result;
           
            if (uye != null)
            {

                bool sifreDogruMu = _userManager.CheckPasswordAsync(uye, login.Sifre).Result;
               
                if (!sifreDogruMu) 
                    uye= null;
                else
                    AdminMi = _userManager.IsInRoleAsync(uye, "Admin").Result;

            }
            
            return Task.FromResult(uye);
        }

        public async Task YeniUyeEkleAsync(UyeEkle_DTO uye)
        {
            Uye yeniUye = new Uye();
            yeniUye.Ad = uye.Ad;
            yeniUye.Soyad = uye.Soyad;
            yeniUye.Adres = uye.Adres;
            yeniUye.UserName = uye.EPosta;
            yeniUye.Email = uye.EPosta;

            PasswordHasher<Uye> passwordHasher = new PasswordHasher<Uye>();
            yeniUye.PasswordHash = passwordHasher.HashPassword(yeniUye, uye.Sifre);
            await _userManager.CreateAsync(yeniUye);
            //Sisteme kaydedilen tüm üyeler "üye" olarak eklenir...
            await _userManager.AddToRoleAsync(yeniUye, "User");
        }
    }
}
