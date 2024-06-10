using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;

namespace UrunPrj.Application.Services.KategoriService
{
    public interface IKategoriService
    {
        Task<IEnumerable<KategoriDTO>> TumKategorilerAsync();
      

        //Diğerlerini ihtiyaca göre tanımla...
    }
}
