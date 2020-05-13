using MyShopSolution.Application.Catalogs.Products.Dtos;
using MyShopSolution.Application.Catalogs.Products.Dtos.Manage;
using MyShopSolution.Application.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSolution.Application.Catalogs.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
