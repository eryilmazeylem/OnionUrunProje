using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class FaturaRepository : BaseRepository<Fatura>, IFaturaRepository
    {
        public FaturaRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }

        public async Task<Fatura> FaturalastirAsync(Fatura fatura)
        {
            //???
            //Once PK olusmalı .... FaturaID
           
            fatura.EklenmeTarihi=DateTime.Now;
            fatura.KayitDurumu = Domain.Enums.KayitDurumu.Aktif;
            await _dbSet.AddAsync(fatura);
            await _dbContext.SaveChangesAsync();

            return fatura;
        }
    }
}
