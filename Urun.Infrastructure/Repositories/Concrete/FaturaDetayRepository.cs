using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class FaturaDetayRepository : BaseRepository<FaturaDetay>,IFaturaDetayRepository
    {
        public FaturaDetayRepository(UrunDBContext dbContext) : base(dbContext)
        {
        }

        public async Task FaturaDetayEkleAsync(params FaturaDetay[] detaylar)
        {
            foreach (var item in detaylar)
            {
                item.EklenmeTarihi=DateTime.Now;
                item.KayitDurumu = Domain.Enums.KayitDurumu.Aktif;
            }
           await _dbSet.AddRangeAsync(detaylar);
           await _dbContext.SaveChangesAsync();
        }
    }
}
