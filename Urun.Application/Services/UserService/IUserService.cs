using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UrunPrj.Application.Models.DTOs.Login;
using UrunPrj.Domain.Models;

namespace UrunPrj.Application.Services.UserService
{
    public interface IUserService
    {
        Task YeniUyeEkleAsync(UyeEkle_DTO uye);
        Task<Uye> Login(Login_DTO login,out bool AdminMi);
        //Task Logout();

        int GetUserID(ClaimsPrincipal principal);

        //ihtiyaca binaen gerekli olan metodlar buraya yazılmalı...
    }
}
