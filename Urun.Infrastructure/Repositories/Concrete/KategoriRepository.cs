using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;

namespace UrunPrj.Infrastructure.Repositories.Concrete
{
    public class KategoriRepository : BaseRepository<Kategori>,IKategoriRepository
    {
        public KategoriRepository(UrunDBContext dbContext) : base(dbContext)
        {

        }
    }
}
