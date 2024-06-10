using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Infrastructure.EntityTypeConfigurations
{
    public class KategoriCFG : Base_CFG<Kategori>, IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);

            builder.HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Kırtasiye", EklenmeTarihi = DateTime.Now, KayitDurumu = Domain.Enums.KayitDurumu.Aktif },
                new Kategori { KategoriID = 2, KategoriAdi = "Elektronik", EklenmeTarihi = DateTime.Now, KayitDurumu = Domain.Enums.KayitDurumu.Aktif },
                new Kategori { KategoriID = 3, KategoriAdi = "Hediyelik Eşya", EklenmeTarihi = DateTime.Now, KayitDurumu = Domain.Enums.KayitDurumu.Aktif });
          }
    }
}
