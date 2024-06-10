using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class FaturaRepository : BaseRepository<Fatura>,IFaturaRepository
    {
        public FaturaRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }
    }
}
