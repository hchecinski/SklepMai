using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using FluentValidation;
using SklepMai.Domain.Repositories;

namespace SklepMai.Core.Functions.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        private readonly IProductRepository _producRepository;

        public CreateProductCommandValidator(IProductRepository productRepository)
        {
            _producRepository = productRepository;

            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .MaximumLength(100)
                .WithMessage("{PropertyName} must not exceed 100 characters")
                .MustAsync(IsProductNameAlreadyExist)
                .WithMessage("Used name of product already exist");

            RuleFor(p => p.Description)
                .MaximumLength(10000)
                .WithMessage("{PropertyName} must not exceed 10000 characters");

            RuleFor(p => p.Price)
                .GreaterThan(0M)
                .WithMessage("{PropertyName} must be greater then 0");

            RuleFor(p => p.CreatorId)
                .GreaterThan(0)
                .WithMessage("{PropertyName} must be greater then 0");

        }

        private async Task<bool> IsProductNameAlreadyExist(string productName, CancellationToken cancellationToken)
        {
            var check = await _producRepository.IsProductNameAlreadyExist(productName);

            return !check;
        }

    }
}