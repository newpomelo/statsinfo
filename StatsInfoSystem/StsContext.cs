﻿using System.Data.Entity;

namespace StatsInfoSystem
{
    public class StsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
    }
}
