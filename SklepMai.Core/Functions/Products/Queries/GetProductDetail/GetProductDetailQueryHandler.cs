using AutoMapper;
using MediatR;
using SklepMai.Domain.Repositories;

namespace SklepMai.Core.Functions.Products.Queries.GetProductDetail
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetail>
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }        
        
        public async Task<ProductDetail> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetItemById(request.Id);

            return _mapper.Map<ProductDetail>(product);
        }
    }
}