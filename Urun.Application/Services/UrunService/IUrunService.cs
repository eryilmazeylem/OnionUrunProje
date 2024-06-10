using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Urun;
using UrunPrj.Application.Models.ViewModels.Urun;

namespace UrunPrj.Application.Services.UrunService
{
    public interface IUrunService
    {
        Task UrunEkleAsync(UrunEkleDTO urun);
        Task UrunSilAsync(int id);

        Task UrunGuncelleAsync(UrunGuncelleDTO urun);
        Task<UrunDetayAppVM> UrunBulAsync(int id);
        Task<IEnumerable<UrunVitrinDTO>> UrunListeleAsync();
    }
}
