using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Application.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        //gerekli Repoları kullan..

        private readonly IKategoriRepository _kategoriRepository;
        private readonly IMapper _mapper;

        public KategoriService(IKategoriRepository kategoriRepository, IMapper mapper)
        {
            _kategoriRepository = kategoriRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<KategoriDTO>> TumKategorilerAsync()
        {
            List<KategoriDTO> kategoriler=new List<KategoriDTO>();

            var _gelenKategoriler = await _kategoriRepository.ListeleAsync();

            //Mapper'ı tanımla.
            _mapper.Map(_gelenKategoriler, kategoriler);

            return kategoriler;
        }
    }
}
