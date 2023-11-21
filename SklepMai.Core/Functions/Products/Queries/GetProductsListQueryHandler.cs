using AutoMapper;
using MediatR;
using SklepMai.Domain.Repositories;

namespace SklepMai.Core.Functions.Products.Queries
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductInList>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductInList>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var all = await _productRepository.GetAllItems();
            var allorderer = all.OrderBy(x => x.CreatedAt);

            return _mapper.Map<List<ProductInList>>(allorderer);
        }
    }
}