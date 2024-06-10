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
    public class FaturaCFG : Base_CFG<Fatura>, IEntityTypeConfiguration<Fatura>
    {
      public  void Configure(EntityTypeBuilder<Fatura> builder)
        {
            base.Configure(builder);
        }
    }
}
