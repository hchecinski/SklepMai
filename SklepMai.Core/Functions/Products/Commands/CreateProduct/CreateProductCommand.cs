using MediatR;

namespace SklepMai.Core.Functions.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CreatorId { get; set; } = 0;
        public decimal Price { get; set; } = 0M;
        public string ImageUrl { get; set; } = string.Empty;
    }
}