using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Fatura;

namespace UrunPrj.Application.Services.FaturaService
{
    public interface IFaturaService
    {
        Task FaturaOlusturAsync(int uyeID);
    }
}
