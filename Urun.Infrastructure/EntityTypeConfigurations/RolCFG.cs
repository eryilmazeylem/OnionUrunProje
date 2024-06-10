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
    public class RolCFG : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasData(
                new Rol { Id = 1, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Rol { Id = 2, Name = "User", NormalizedName = "USER", ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
    }
}
