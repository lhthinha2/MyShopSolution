﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.ViewModel.Catalogs.Products
{
    public class ProductImageViewModel
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreate { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }
    }
}
