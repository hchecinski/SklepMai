using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace SklepMai.Core.Functions.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CreatorId { get; set; } = 0;
        public decimal? Price { get; set; } = null;
        public string ImageUrl { get; set; } = string.Empty;
    }
}