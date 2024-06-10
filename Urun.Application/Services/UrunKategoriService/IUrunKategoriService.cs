using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Kategori;

namespace UrunPrj.Application.Services.UrunKategoriService
{
    public interface IUrunKategoriService
    {
       Task< IEnumerable<KategoriDTO> >UrununKategorileriAsync(int id);

        Task UrunKategorisiEkleAsync(int UrunID,int KategoriID);
    }
}
