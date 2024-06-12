using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Urun;
using UrunPrj.Application.Models.ViewModels.Urun;
using UrunPrj.Application.Services.UrunKategoriService;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Application.Services.UrunService
{
    public class UrunService : IUrunService
    {
        private readonly IUrunRepository _urunRepository;
        private readonly IUrunKategoriService _urunKategoriService;
        private readonly IMapper _mapper;

        public UrunService(IUrunRepository urunRepository, IUrunKategoriService urunKategoriService, IMapper mapper)
        {
            _urunRepository = urunRepository;
            _urunKategoriService = urunKategoriService;
            _mapper = mapper;
        }

        public async Task<UrunDetayAppVM> UrunBulAsync(int id)
        {
           UrunDetayAppVM urunDetay=new UrunDetayAppVM();
          var detay=await _urunRepository.AraAsync(id);
            _mapper.Map(detay, urunDetay);
            urunDetay.UrununKategorileri=await _urunKategoriService.UrununKategorileriAsync(id);
            return urunDetay;
        }

        public async Task UrunEkleAsync(UrunEkleDTO urun)
        {
            //içinde veri olan ilk parametre(urun) boş olan ikinci parametre(yeniUrun)
            Urun yeniUrun = new Urun();
            _mapper.Map(urun, yeniUrun);
         var gelenUrun=  await _urunRepository.EkleAsync(yeniUrun);

            //Problem?? UrunID
            foreach(int id in urun.SecilenKategoriler)
            {
                await _urunKategoriService.UrunKategorisiEkleAsync(gelenUrun.UrunID, id);
            }
        }

        public Task UrunGuncelleAsync(UrunGuncelleDTO urun)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UrunVitrinDTO>> UrunListeleAsync()
        {
            List<UrunVitrinDTO> _urunler= new List<UrunVitrinDTO>();
            var gelenUrunler = await _urunRepository.ListeleAsync();
            _mapper.Map(gelenUrunler,_urunler);
            return _urunler;
        }

        public Task UrunSilAsync(int id)
        {
            throw new NotImplementedException();
        }

     

        public async Task UrunuStoktanDusAsync(int urunID, int dusulecekAdet)
        {
            var urun = await _urunRepository.AraAsync(urunID);
            urun.StokAdedi=urun.StokAdedi-dusulecekAdet;

           await  _urunRepository.GuncelleAsync(urun);
        }
    }
}
