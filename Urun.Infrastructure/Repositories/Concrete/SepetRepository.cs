using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class SepetRepository : BaseRepository<Sepet>,ISepetRepository
    {
        public SepetRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }

        public async Task SepettekiUrunleriTemizleAsync(int uyeID)
        {
            var sepettekiUrunler = await _dbSet.Where(x => x.UyeID == uyeID).ToListAsync();
            _dbSet.RemoveRange(sepettekiUrunler);
           await _dbContext.SaveChangesAsync();
        }

        public async Task SepettekiUrunuTemizleAsync(int id)
        {
            var sepettekiUrun =await _dbSet.FindAsync(id);
            _dbSet.Remove(sepettekiUrun);
           await _dbContext.SaveChangesAsync();
        }
    }
}
