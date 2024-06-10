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
    public class UrunCFG : Base_CFG<Urun>, IEntityTypeConfiguration<Urun>
    {
      public  void Configure(EntityTypeBuilder<Urun> builder)
        {
           base.Configure(builder);

            builder.Property(x => x.BirimFiyat).HasColumnType("money");
            builder.HasData(new Urun { UrunID=1,UrunAdi="Hesap Makinasi",BirimFiyat=2500,StokAdedi=10,EklenmeTarihi=DateTime.Now,KayitDurumu=Domain.Enums.KayitDurumu.Aktif});
        }
    }
}
