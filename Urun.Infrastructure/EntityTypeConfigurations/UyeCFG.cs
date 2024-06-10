using Microsoft.AspNetCore.Identity;
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
    public class UyeCFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            var uye = new Uye
            {
                Id=1,
                Ad="Super",
                Soyad="User",
                Adres="Sapace",
                UserName="superadmin@deneme.com",
                NormalizedEmail="SUPERADMIN@DENEME.COM",
                Email= "superadmin@deneme.com",
                NormalizedUserName= "SUPERADMIN@DENEME.COM",
                ConcurrencyStamp=Guid.NewGuid().ToString(),
                SecurityStamp=Guid.NewGuid().ToString(),
                EmailConfirmed=false,
            };

            PasswordHasher<Uye> hasher = new PasswordHasher<Uye>();
            uye.PasswordHash = hasher.HashPassword(uye, "sprAdmn_123");
            builder.HasData(uye);
        }
    }
}
