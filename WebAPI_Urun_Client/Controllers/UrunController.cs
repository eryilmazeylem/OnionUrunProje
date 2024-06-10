using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UrunPrj.Application.Services.UrunService;

namespace WebAPI_Urun_Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IUrunService _urunService;
        private readonly IMapper _mapper;

        public UrunController(IUrunService urunService, IMapper mapper)
        {
            _urunService = urunService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {

            var urunler = await _urunService.UrunListeleAsync();
            return Ok(urunler);
        }
    }
}
