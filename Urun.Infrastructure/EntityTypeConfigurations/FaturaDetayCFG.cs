using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Domain.Models;

namespace UrunPrj.Infrastructure.EntityTypeConfigurations
{
    public class FaturaDetayCFG : Base_CFG<FaturaDetay>, IEntityTypeConfiguration<FaturaDetay>
    {
      public  void Configure(EntityTypeBuilder<FaturaDetay> builder)
        {
           base.Configure(builder); 
        }
    }
}
