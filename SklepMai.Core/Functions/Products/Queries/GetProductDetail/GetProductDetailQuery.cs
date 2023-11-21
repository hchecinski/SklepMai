using MediatR;

namespace SklepMai.Core.Functions.Products.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<ProductDetail>
    {
        public int Id { get; set; }
    }
}