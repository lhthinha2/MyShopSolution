using MyShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.ViewModel.Catalogs.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
