using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Application.CommonDtos
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
