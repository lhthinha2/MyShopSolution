using MyShopSolution.Application.Catalogs.Products.Dtos;
using MyShopSolution.Application.Catalogs.Products.Dtos.Public;
using MyShopSolution.Application.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSolution.Application.Catalogs.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
