using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunPrj.Application.Models.ViewModels.Login
{
    public class Login_VM
    {
        [Required,EmailAddress]
        public string EPosta { get; set; }

        [Required]
        public string Sifre { get; set; }
    }
}
