using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShopSolution.ViewModel.Common;
using MyShopSolution.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}
