﻿using MyShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.ViewModel.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}