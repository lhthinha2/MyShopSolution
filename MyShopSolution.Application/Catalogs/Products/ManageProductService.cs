using MyShopSolution.Application.Catalogs.Products.Dtos;
using MyShopSolution.Application.Catalogs.Products.Dtos.Manage;
using MyShopSolution.Application.CommonDtos;
using MyShopSolution.Data.EF;
using MyShopSolution.Data.Entities;
using MyShopSolution.Utilities.Exceptions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyShopSolution.Application.Catalogs.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly MyShopDbContext _context;

        public ManageProductService(MyShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoAlias= request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        SeoDescription = request.SeoDescription,
                        LanguageId=request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new MyShopException($"Cannot find a product: {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //1. select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };

            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));

            if (request.CategoryId.Count > 0)
                query = query.Where(p => request.CategoryId.Contains(p.pic.CategoryId));

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) + request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }
                ).ToListAsync();

            //4. select and projection
            var pagedRusult = new PagedResult<ProductViewModel>
            {
                TotalRecord = totalRow,
                Item = data
            };

            return pagedRusult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id
            && x.LanguageId == request.LanguageId);

            if (product == null || productTranslation == null) throw new MyShopException($"Cannot find a product: {request.Id}");

            productTranslation.Name = request.Name;
            productTranslation.SeoAlias = request.SeoAlias;
            productTranslation.SeoDescription = request.SeoDescription;
            productTranslation.SeoTitle = request.SeoTitle;
            productTranslation.Description = request.Description;
            productTranslation.Details = request.Details;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new MyShopException($"Cannot find a product: {productId}");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new MyShopException($"Cannot find a product: {productId}");
            product.Stock += addedQuantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
