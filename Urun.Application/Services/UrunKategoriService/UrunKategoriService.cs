using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Application.Services.UrunKategoriService
{
    public class UrunKategoriService : IUrunKategoriService
    {
        private readonly IUrunKategoriRepository _urunKategoriRepository;

        public UrunKategoriService(IUrunKategoriRepository urunKategoriRepository)
        {
            _urunKategoriRepository = urunKategoriRepository;
        }

        public async Task UrunKategorisiEkleAsync(int urunID, int kategoriID)
        {
            UrunKategori urunKategori=new UrunKategori { UrunID=urunID,KategoriID=kategoriID};
           await _urunKategoriRepository.EkleAsync(urunKategori);
        }

        public async Task<IEnumerable<KategoriDTO>> UrununKategorileriAsync(int id)
        {
          return await  _urunKategoriRepository.ListeleAsync(
                select:x=>new KategoriDTO { KategoriID=x.KategoriID,KategoriAdi=x.Kategori.KategoriAdi},
                where:x=>x.UrunID==id,
                orderBy:x=>x.OrderBy(x=>x.Kategori.KategoriAdi),
                include:x=>x.Include(x=>x.Kategori)
                );
        }
    }
}
