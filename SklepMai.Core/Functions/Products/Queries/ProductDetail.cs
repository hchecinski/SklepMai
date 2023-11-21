using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepMai.Core.Functions.Products.Queries
{
    public class ProductDetail
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal? Price { get; set; } = null;
    }
}