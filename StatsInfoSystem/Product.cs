﻿
namespace StatsInfoSystem
{
    public class ProductGroup
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class ProductCategory
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public string Code { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public ProductGroup group { get; set; }
    }
}
