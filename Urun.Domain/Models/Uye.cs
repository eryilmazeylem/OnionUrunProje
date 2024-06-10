
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Domain.Models
{
    public class Uye:IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }

        public ICollection<Fatura>? Faturalar { get; set; }
        public ICollection<Sepet> ? UyeninSepetleri { get; set; }
    }                             
}
