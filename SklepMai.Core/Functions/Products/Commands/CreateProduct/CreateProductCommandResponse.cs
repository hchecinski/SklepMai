using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace SklepMai.Core.Functions.Products.Commands.CreateProduct
{
    public class CreateProductCommandResponse : BaseResponse
    {
        public int? ProductId { get; private set; } = null;

        public CreateProductCommandResponse(int productId)
        {
            ProductId = productId;
        }

        public CreateProductCommandResponse(ValidationResult validationResult)
            : base(validationResult) 
        {

        }
    }
}