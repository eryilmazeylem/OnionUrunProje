using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.ViewModels.Login
{
    public class UyeEkle_VM
    {
        [Required] 
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        [Required]
        public string EPosta { get; set; }

        [Required]
        public string Adres { get; set; }


        [Compare("SifreTekrari"),Required]
        public string Sifre { get; set; }

        [Required]
        public string SifreTekrari { get; set; }

    }
}
