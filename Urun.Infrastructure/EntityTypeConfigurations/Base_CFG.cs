using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models.Abstract;

namespace UrunPrj.Infrastructure.EntityTypeConfigurations
{
    public abstract class Base_CFG<TEntity> where TEntity :class, IEntity
    {

        protected void Configure(EntityTypeBuilder<TEntity> builder) //Dikkat Tentity Yaptık
        {
            builder.Property(x => x.EklenmeTarihi).HasColumnType("smalldatetime");
            builder.Property(x => x.DegismeTarihi).HasColumnType("smalldatetime");
            builder.Property(x => x.SilmeTarihi).HasColumnType("smalldatetime");
        }
    }
}
