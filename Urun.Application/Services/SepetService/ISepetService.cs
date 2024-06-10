using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Sepet;
using UrunPrj.Application.Models.ViewModels.Sepet;

namespace UrunPrj.Application.Services.SepetService
{
    public interface ISepetService
    {
        Task SepeteEkleAsync(SepeteEkleDTO sepeteEkle);
        Task SepettekiAdediGuncelleAsync(SepetiGuncelleDTO sepetiGuncelle);
        //SepetRepositorydeki metodu kullan
        Task TumSepetiSilAsync(int uyeID);
        //SepetRepositorydeki metodu kullan
        Task SepettekiUrunuSilAsync(int id);
        Task<IEnumerable<SepettekiUrunVM>> SepettekiUrunleriListeleAsync(int uyeID);


    }
}
