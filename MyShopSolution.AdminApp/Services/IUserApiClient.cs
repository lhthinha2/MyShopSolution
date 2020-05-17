using MyShopSolution.ViewModel.Common;
using MyShopSolution.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserViewModel>> GetUserPagings(GetUserPagingRequest request);
    }
}
