using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UrunPrj.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "money", nullable: false),
                    ResimAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturalar",
                columns: table => new
                {
                    FaturaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeID = table.Column<int>(type: "int", nullable: false),
                    FaturaKesimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamFaturaTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.FaturaID);
                    table.ForeignKey(
                        name: "FK_Faturalar_AspNetUsers_UyeID",
                        column: x => x.UyeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sepetler",
                columns: table => new
                {
                    SepetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    UyeID = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepetler", x => x.SepetID);
                    table.ForeignKey(
                        name: "FK_Sepetler_AspNetUsers_UyeID",
                        column: x => x.UyeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sepetler_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrunKategorileri",
                columns: table => new
                {
                    UrunKategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunKategorileri", x => x.UrunKategoriID);
                    table.ForeignKey(
                        name: "FK_UrunKategorileri_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunKategorileri_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaDetaylari",
                columns: table => new
                {
                    FaturaDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DegismeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaDetaylari", x => x.FaturaDetayID);
                    table.ForeignKey(
                        name: "FK_FaturaDetaylari_Faturalar_FaturaID",
                        column: x => x.FaturaID,
                        principalTable: "Faturalar",
                        principalColumn: "FaturaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaturaDetaylari_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "ce35eec2-6a5d-4425-88a5-d8e3724040d0", "Admin", "ADMIN" },
                    { 2, "741e3288-56bd-432c-b327-ce4d90311461", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "Adres", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "Super", "Sapace", "111de05e-1436-4065-ba8b-ef7257a228ac", "superadmin@deneme.com", false, false, null, "SUPERADMIN@DENEME.COM", "SUPERADMIN@DENEME.COM", "AQAAAAIAAYagAAAAEPjRO1pJcqyYDFKKicyqkgQXGcVvbXfB/1CMz1XdDmCoPKAC/AyUXr+OADE1Xi0uXw==", null, false, "7764e2a8-e368-4c18-8538-4ef1d085cc05", "User", false, "superadmin@deneme.com" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "DegismeTarihi", "EklenmeTarihi", "KategoriAdi", "KayitDurumu", "SilmeTarihi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2681), "Kırtasiye", 1, null },
                    { 2, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2694), "Elektronik", 1, null },
                    { 3, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(2695), "Hediyelik Eşya", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunID", "BirimFiyat", "DegismeTarihi", "EklenmeTarihi", "KayitDurumu", "ResimAdi", "SilmeTarihi", "StokAdedi", "UrunAdi" },
                values: new object[] { 1, 2500m, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(5490), 1, "bosUrun.jpg", null, 10, "Hesap Makinasi" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "UrunKategorileri",
                columns: new[] { "UrunKategoriID", "DegismeTarihi", "EklenmeTarihi", "KategoriID", "KayitDurumu", "SilmeTarihi", "UrunID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(6286), 1, 1, null, 1 },
                    { 2, null, new DateTime(2024, 6, 6, 14, 11, 56, 429, DateTimeKind.Local).AddTicks(6289), 2, 1, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylari_FaturaID",
                table: "FaturaDetaylari",
                column: "FaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylari_UrunID",
                table: "FaturaDetaylari",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_UyeID",
                table: "Faturalar",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sepetler_UrunID",
                table: "Sepetler",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Sepetler_UyeID",
                table: "Sepetler",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunKategorileri_KategoriID",
                table: "UrunKategorileri",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_UrunKategorileri_UrunID",
                table: "UrunKategorileri",
                column: "UrunID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FaturaDetaylari");

            migrationBuilder.DropTable(
                name: "Sepetler");

            migrationBuilder.DropTable(
                name: "UrunKategorileri");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
