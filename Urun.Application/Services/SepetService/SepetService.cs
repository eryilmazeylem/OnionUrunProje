using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Sepet;
using UrunPrj.Application.Models.ViewModels.Sepet;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Application.Services.SepetService
{
    public class SepetService : ISepetService
    {
        private readonly ISepetRepository _sepetRepository;
        private readonly IMapper _mapper;

        public SepetService(ISepetRepository sepetRepository, IMapper mapper)
        {
            _sepetRepository = sepetRepository;
            _mapper = mapper;
        }

        public async Task SepeteEkleAsync(SepeteEkleDTO sepeteEkle)
        {
            //Yoksa insert varsa adedi update et(Adet++)
            Sepet sepet = new Sepet();
            _mapper.Map(sepeteEkle, sepet);
            
            var sepettekiUrunSayisi= _sepetRepository.ListeleAsync(x=>x,x=>x.UyeID==sepeteEkle.UyeID&&x.UrunID==sepeteEkle.UrunID).Result.Count();
            if (sepettekiUrunSayisi==0)
            {
                sepet.Adet = 1;
                await _sepetRepository.EkleAsync(sepet);
            }
            else
            {
                var varOlanSepet =  _sepetRepository.ListeleAsync(x => x, x => x.UyeID == sepeteEkle.UyeID && x.UrunID == sepeteEkle.UrunID).Result.Single();
               varOlanSepet.Adet = varOlanSepet.Adet + 1;
                await _sepetRepository.GuncelleAsync(varOlanSepet);
            }
        }

        public async Task SepettekiAdediGuncelleAsync(SepetiGuncelleDTO sepetiGuncelle)
        {
            Sepet sepet = await _sepetRepository.AraAsync(sepetiGuncelle.SepetID);
            sepet.Adet = sepetiGuncelle.Adet;
           // _mapper.Map(sepetiGuncelle, sepet);
            await _sepetRepository.GuncelleAsync(sepet);
        }

        public async Task<IEnumerable<SepettekiUrunVM>> SepettekiUrunleriListeleAsync(int uyeID)
        {

           return await _sepetRepository.ListeleAsync(
                select: x => new SepettekiUrunVM
                { SepetID = x.SepetID,
                UyeID=x.UyeID,
                Adet=x.Adet,
                UrunID=x.UrunID,
                StoktakiUrunAdedi=x.Urun.StokAdedi,
                UrunAdi=x.Urun.UrunAdi,
                BirimFiyat=x.Urun.BirimFiyat
                
                },
                where:x=>x.UyeID==uyeID,
                orderBy:x=>x.OrderByDescending(x=>x.SepetID),
                include:x=>x.Include(x=>x.Urun)
                );
        }

        public async Task SepettekiUrunuSilAsync(int id)
        {
            await _sepetRepository.SepettekiUrunuTemizleAsync(id);
        }

        public async Task TumSepetiSilAsync(int uyeID)
        {
            await _sepetRepository.SepettekiUrunleriTemizleAsync(uyeID);
        }
    }
}
