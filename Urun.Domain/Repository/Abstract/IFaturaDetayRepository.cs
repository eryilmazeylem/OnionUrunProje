﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;

namespace UrunPrj.Domain.Repository.Abstract
{
    public interface IFaturaDetayRepository:IBaseRepository<FaturaDetay>
    {
        Task FaturaDetayEkleAsync(params FaturaDetay[] detaylar);
    }
}
