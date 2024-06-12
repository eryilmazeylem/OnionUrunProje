using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Fatura;
using UrunPrj.Application.Services.SepetService;
using UrunPrj.Application.Services.UrunService;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Application.Services.FaturaService
{
    public class FaturaService : IFaturaService
    {
        private readonly IUrunService _urunService;
        private readonly ISepetService _sepetService;
        private readonly IFaturaRepository _faturaRepository;
        private readonly IFaturaDetayRepository _faturaDetayRepository;
        private readonly IMapper _mapper;

        public FaturaService(IUrunService urunService, ISepetService sepetService, IFaturaRepository faturaRepository, IFaturaDetayRepository faturaDetayRepository, IMapper mapper)
        {
            _urunService = urunService;
            _sepetService = sepetService;
            _faturaRepository = faturaRepository;
            _faturaDetayRepository = faturaDetayRepository;
            _mapper = mapper;
        }

        public async Task FaturaOlusturAsync(int uyeID)
        {

            List<FaturaDetay> faturaDetaylari = new List<FaturaDetay>();
            var sepettekiUrunler = await _sepetService.SepettekiUrunleriListeleAsync(uyeID);
            decimal faturaninToplamTutari = 0;

            //Sepetteki urunlerin stoktan düş
            foreach (var item in sepettekiUrunler)
            {

                faturaninToplamTutari += item.BirimFiyat * item.Adet;
                await _urunService.UrunuStoktanDusAsync(item.UrunID, item.Adet);
                FaturaDetay detay = new FaturaDetay { UrunID = item.UrunID, Adet = item.Adet, BirimFiyat = item.BirimFiyat };

                faturaDetaylari.Add(detay);
            }
            Fatura fatura = new Fatura();
            fatura.UyeID = uyeID;
            fatura.FaturaKesimTarihi = DateTime.Now;
            fatura.ToplamFaturaTutari = faturaninToplamTutari;


            //Fatura ve fatura detay tablosuna verileri kaydet
            Fatura yeniFatura = await _faturaRepository.FaturalastirAsync(fatura);

            foreach (var item in faturaDetaylari)
           
                item.FaturaID=yeniFatura.FaturaID;
            


           await _faturaDetayRepository.FaturaDetayEkleAsync(faturaDetaylari.ToArray());

            // tum işlemlerden sonra sepeti sil
            await _sepetService.TumSepetiSilAsync(uyeID);


        }
    }
}
