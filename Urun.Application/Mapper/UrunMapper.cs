using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;
using UrunPrj.Application.Models.DTOs.Login;
using UrunPrj.Application.Models.DTOs.Sepet;
using UrunPrj.Application.Models.DTOs.Urun;
using UrunPrj.Application.Models.ViewModels.Login;
using UrunPrj.Application.Models.ViewModels.Sepet;
using UrunPrj.Application.Models.ViewModels.Urun;
using UrunPrj.Domain.Models;

namespace UrunPrj.Application.Mapper
{
    public class UrunMapper:Profile
    {
        public UrunMapper()
        {
            //Map'lenecek tüm sınıfları burada tanımla...
            CreateMap<Login_VM,Login_DTO>().ReverseMap();
            CreateMap<UyeEkle_VM,UyeEkle_DTO>().ReverseMap(); 
            
            CreateMap<Kategori,KategoriDTO>().ReverseMap();

            CreateMap<Urun,UrunEkleDTO>().ReverseMap();
            CreateMap<Urun,UrunVitrinDTO>().ReverseMap();
            CreateMap<Urun,UrunDetayAppVM>().ReverseMap();

            CreateMap<Sepet,SepeteEkleDTO>().ReverseMap();
            CreateMap<Sepet,SepetiGuncelleDTO>().ReverseMap();
            
          
        }
    }
}
