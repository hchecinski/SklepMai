using AutoMapper;
using MediatR;
using SklepMai.Domain.Models;
using SklepMai.Domain.Repositories;

namespace SklepMai.Core.Functions.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }  

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductCommandValidator(_productRepository);
            var validatorResult = await validator.ValidateAsync(request);

            if(!validatorResult.IsValid)
            {
                return new CreateProductCommandResponse(validatorResult);
            }

            var product = _mapper.Map<ProductDto>(request);
            var productId = await _productRepository.AddItem(product);

            return new CreateProductCommandResponse(productId);
        }
    }
}