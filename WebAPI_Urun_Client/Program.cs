using Microsoft.EntityFrameworkCore;
using UrunPrj.Application.Mapper;
using UrunPrj.Application.Services.KategoriService;
using UrunPrj.Application.Services.SepetService;
using UrunPrj.Application.Services.UrunKategoriService;
using UrunPrj.Application.Services.UrunService;
using UrunPrj.Application.Services.UserService;
using UrunPrj.Domain.Models;
using UrunPrj.Domain.Repository.Abstract;
using UrunPrj.Infrastructure.Repositories.Concrete;
using UrunPrj.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext
builder.Services.AddDbContext<UrunDBContext>(x => x.UseSqlServer());

//Identity
builder.Services.AddIdentity<Uye, Rol>().AddEntityFrameworkStores<UrunDBContext>().AddRoles<Rol>();

//Mapper
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(UrunMapper)));

//IOC(container a projede ihtiyaç olan sýnýflarý ekliyoruz.Nesnenin instance ýný alýp bana gönderiyor. Controller da ctor ýnjeksda newliyor)
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IKategoriRepository, KategoriRepository>();
builder.Services.AddTransient<IKategoriService, KategoriService>();


builder.Services.AddTransient<IUrunRepository, UrunRepository>();
builder.Services.AddTransient<IUrunService, UrunService>();

builder.Services.AddTransient<IUrunKategoriRepository, UrunKategoriRepository>();
builder.Services.AddTransient<IUrunKategoriService, UrunKategoriService>();

builder.Services.AddTransient<ISepetRepository, SepetRepository>();
builder.Services.AddTransient<ISepetService, SepetService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
