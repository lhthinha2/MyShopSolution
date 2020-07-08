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
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest request);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUserPagings(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);
    }
}
