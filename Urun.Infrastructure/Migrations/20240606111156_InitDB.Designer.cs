﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrunPrj.Infrastructure;

#nullable disable

namespace UrunPrj.Infrastructure.Migrations
{
    [DbContext(typeof(UrunDBContext))]
    [Migration("20240606111156_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Fatura", b =>
                {
                    b.Property<int>("FaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaID"));

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("FaturaKesimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<decimal>("ToplamFaturaTutari")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("FaturaID");

                    b.HasIndex("UyeID");

                    b.ToTable("Faturalar");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.FaturaDetay", b =>
                {
                    b.Property<int>("FaturaDetayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaDetayID"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("FaturaID")
                        .HasColumnType("int");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("FaturaDetayID");

                    b.HasIndex("FaturaID");

                    b.HasIndex("UrunID");

                    b.ToTable("FaturaDetaylari");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2681),
                            KategoriAdi = "Kırtasiye",
                            KayitDurumu = 1
                        },
                        new
                        {
                            KategoriID = 2,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2694),
                            KategoriAdi = "Elektronik",
                            KayitDurumu = 1
                        },
                        new
                        {
                            KategoriID = 3,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2695),
                            KategoriAdi = "Hediyelik Eşya",
                            KayitDurumu = 1
                        });
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "ce35eec2-6a5d-4425-88a5-d8e3724040d0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "741e3288-56bd-432c-b327-ce4d90311461",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Sepet", b =>
                {
                    b.Property<int>("SepetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SepetID"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("SepetID");

                    b.HasIndex("UrunID");

                    b.HasIndex("UyeID");

                    b.ToTable("Sepetler");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunID"));

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("money");

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<string>("ResimAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("StokAdedi")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunID");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            UrunID = 1,
                            BirimFiyat = 2500m,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(5490),
                            KayitDurumu = 1,
                            ResimAdi = "bosUrun.jpg",
                            StokAdedi = 10,
                            UrunAdi = "Hesap Makinasi"
                        });
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.UrunKategori", b =>
                {
                    b.Property<int>("UrunKategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunKategoriID"));

                    b.Property<DateTime?>("DegismeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("EklenmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("KayitDurumu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("UrunID")
                        .HasColumnType("int");

                    b.HasKey("UrunKategoriID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("UrunID");

                    b.ToTable("UrunKategorileri");

                    b.HasData(
                        new
                        {
                            UrunKategoriID = 1,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(6286),
                            KategoriID = 1,
                            KayitDurumu = 1,
                            UrunID = 1
                        },
                        new
                        {
                            UrunKategoriID = 2,
                            EklenmeTarihi = new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(6289),
                            KategoriID = 2,
                            KayitDurumu = 1,
                            UrunID = 1
                        });
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Ad = "Super",
                            Adres = "Sapace",
                            ConcurrencyStamp = "111de05e-1436-4065-ba8b-ef7257a228ac",
                            Email = "superadmin@deneme.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@DENEME.COM",
                            NormalizedUserName = "SUPERADMIN@DENEME.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPjRO1pJcqyYDFKKicyqkgQXGcVvbXfB/1CMz1XdDmCoPKAC/AyUXr+OADE1Xi0uXw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7764e2a8-e368-4c18-8538-4ef1d085cc05",
                            Soyad = "User",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@deneme.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrunPrj.Domain.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Fatura", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Uye", "Uye")
                        .WithMany("Faturalar")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.FaturaDetay", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Fatura", "Fatura")
                        .WithMany("FaturaDetayları")
                        .HasForeignKey("FaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrunPrj.Domain.Models.Urun", "Urun")
                        .WithMany("FaturaDetaylari")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fatura");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Sepet", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Urun", "Urun")
                        .WithMany("SepettekiUrunler")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrunPrj.Domain.Models.Uye", "Uye")
                        .WithMany("UyeninSepetleri")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.UrunKategori", b =>
                {
                    b.HasOne("UrunPrj.Domain.Models.Kategori", "Kategori")
                        .WithMany("KategoriUrunleri")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UrunPrj.Domain.Models.Urun", "Urun")
                        .WithMany("UrunKategorileri")
                        .HasForeignKey("UrunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Fatura", b =>
                {
                    b.Navigation("FaturaDetayları");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Kategori", b =>
                {
                    b.Navigation("KategoriUrunleri");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Urun", b =>
                {
                    b.Navigation("FaturaDetaylari");

                    b.Navigation("SepettekiUrunler");

                    b.Navigation("UrunKategorileri");
                });

            modelBuilder.Entity("UrunPrj.Domain.Models.Uye", b =>
                {
                    b.Navigation("Faturalar");

                    b.Navigation("UyeninSepetleri");
                });
#pragma warning restore 612, 618
        }
    }
}
