using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Domain.Repository.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class,IEntity
    {
        //CRUD işlemleri
        Task <TEntity> EkleAsync(TEntity entity);//ID dönecek oluşan primary key
        Task<int> GuncelleAsync(TEntity entity);
        Task<bool> SilAsync(int id);
        Task<TEntity> AraAsync(int id);

        Task<IEnumerable<TEntity>> ListeleAsync();

        //ilerde yeni metodlar gelecek...

        Task<IEnumerable<TResult>> ListeleAsync<TResult>
            (Expression<Func<TEntity, TResult>> select,
            Expression<Func<TEntity, bool>> where,
            Func<IQueryable< TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable< TEntity>, IIncludableQueryable<TEntity, object>> include = null); //4 parametreli select,where,orderby,include
        
    }
}
