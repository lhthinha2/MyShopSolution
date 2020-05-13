using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Application.CommonDtos
{
    public class PagedResult<T>
    {
        public List<T> Item { get; set; }
        public int TotalRecord { get; set; }
    }
}
