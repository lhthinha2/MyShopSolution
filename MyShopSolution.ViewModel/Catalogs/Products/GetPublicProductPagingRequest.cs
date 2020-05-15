using MyShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.ViewModel.Catalogs.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
