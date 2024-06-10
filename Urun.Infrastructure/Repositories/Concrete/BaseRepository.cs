using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models.Abstract;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly UrunDBContext _dbContext;

        protected DbSet<TEntity> _dbSet;

        public BaseRepository(UrunDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet =_dbContext.Set<TEntity>();
        }

        public async Task<TEntity> AraAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> EkleAsync(TEntity entity)
        {
            entity.EklenmeTarihi=DateTime.Now;
            entity.KayitDurumu = Domain.Enums.KayitDurumu.Aktif;

           await _dbSet.AddAsync(entity);
         var result=  await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> GuncelleAsync(TEntity entity)
        {
            entity.DegismeTarihi = DateTime.Now;
            entity.KayitDurumu = Domain.Enums.KayitDurumu.Değişti;

            _dbSet.Update(entity);
          var result= await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<TEntity>> ListeleAsync()
        {
            return await _dbSet.Where(x=>x.KayitDurumu==Domain.Enums.KayitDurumu.Aktif).ToListAsync();
        }

        public async Task<IEnumerable<TResult>> ListeleAsync<TResult>
            (Expression<Func<TEntity, TResult>> select, 
            Expression<Func<TEntity, bool>> where, 
            Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if(where != null)
                query = query.Where(where);
            if (include != null)
                query = include(query);
            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();
            else
                return await query.Select(select).ToListAsync();
        }

        public async Task<bool> SilAsync(int id)
        {
            var entity= await AraAsync(id);
            int kayitSayisi = 0;
            if (entity != null)
            {
                entity.SilmeTarihi= DateTime.Now;
                entity.KayitDurumu = Domain.Enums.KayitDurumu.Silindi;
                _dbSet.Update(entity) ;
              kayitSayisi=await  _dbContext.SaveChangesAsync();
            }
            return kayitSayisi > 0?true:false;
        }
    }
}
