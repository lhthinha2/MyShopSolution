using Microsoft.AspNetCore.Http;
using MyShopSolution.ViewModel.Catalogs.ProductImages;
using MyShopSolution.ViewModel.Catalogs.Products;
using MyShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShopSolution.Application.Catalogs.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);
        
        Task<int> Delete(int productId);
        
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        
        Task<bool> UpdateStock(int productId, int addedQuantity);
        
        Task AddViewCount(int productId);
        
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<ProductViewModel> GetById(int productId, string laguageId);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
