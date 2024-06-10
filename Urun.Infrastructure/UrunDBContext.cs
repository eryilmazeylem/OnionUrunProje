using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UrunPrj.Domain.Models;

namespace UrunPrj.Infrastructure
{
    public class UrunDBContext : IdentityDbContext<Uye, Rol, int>
    {

        public UrunDBContext() //Boş ctor olmalı migraion çalışması için
        {
            
        }

        public UrunDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylari { get; set; }
        public DbSet<UrunKategori> UrunKategorileri  { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }

        //Uye ve rol İdentity den geliyor o yüzden tablo olarak yazmadık


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Connection stringi yazıyoruz
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=DESKTOP-3E0S459;Initial catalog=KD20_OnionUrunDB;Integrated security=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder builder)//CFGler için
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { UserId = 1 ,RoleId=1});
        }

       

    }
}
