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
    public class SepetCFG : Base_CFG<Sepet>, IEntityTypeConfiguration<Sepet>
    {
        public void Configure(EntityTypeBuilder<Sepet> builder)
        {
           base.Configure(builder);
        }
    }
}
