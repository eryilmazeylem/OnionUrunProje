using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.DTOs.Sepet
{
    public class SepetiGuncelleDTO
    {
        public int SepetID { get; set; }
        public int UrunID { get; set; }
        public int UyeID { get; set; }
        public int Adet { get; set; }
    }
}
