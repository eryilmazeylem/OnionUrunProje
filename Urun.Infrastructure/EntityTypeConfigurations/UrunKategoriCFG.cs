using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;

namespace UrunPrj.Infrastructure.EntityTypeConfigurations
{
    public class UrunKategoriCFG : Base_CFG<UrunKategori>, IEntityTypeConfiguration<UrunKategori>
    {
        public void Configure(EntityTypeBuilder<UrunKategori> builder)
        {
            base.Configure(builder);

            builder.HasData(new UrunKategori() {UrunKategoriID = 1, UrunID = 1, KategoriID = 1, EklenmeTarihi = DateTime.Now, KayitDurumu = Domain.Enums.KayitDurumu.Aktif },
                new UrunKategori() { UrunKategoriID = 2, UrunID = 1, KategoriID = 2, EklenmeTarihi = DateTime.Now, KayitDurumu = Domain.Enums.KayitDurumu.Aktif });
        }
    }
}
