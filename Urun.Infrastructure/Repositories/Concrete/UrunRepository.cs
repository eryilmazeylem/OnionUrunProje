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
    public class UrunRepository : BaseRepository<Urun>,IUrunRepository
    {
        public UrunRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }
    }
}
