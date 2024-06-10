using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class UrunKategoriRepository : BaseRepository<UrunKategori>,IUrunKategoriRepository
    {
        public UrunKategoriRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }
    }
}
