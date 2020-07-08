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
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUserPaging(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);
    }
}
