using MyShopSolution.Application.CommonDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Application.Catalogs.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
