using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Enums;

namespace UrunPrj.Domain.Models.Abstract
{
    public interface IEntity
    {
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? DegismeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
    }
}
