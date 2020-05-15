using Microsoft.AspNetCore.Http;
using MyShopSolution.ViewModel.Catalogs.Products;
using MyShopSolution.ViewModel.Common;
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
        
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<ProductViewModel> GetById(int productId, string laguageId);

        Task<int> AddImage(int productId, List<IFormFile> files);
        
        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

    }
}
