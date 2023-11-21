using MediatR;

namespace SklepMai.Core.Functions.Products.Queries
{
    public class GetProductDetailQuery : IRequest<ProductDetail>
    {
        public int Id { get; set; }
    }
}