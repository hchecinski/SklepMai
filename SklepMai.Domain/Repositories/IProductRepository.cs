using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SklepMai.Domain.Models;

namespace SklepMai.Domain.Repositories
{
    public interface IProductRepository : IRepository<ProductDto>
    {
        Task<bool> IsProductNameAlreadyExist(string productName);
    }
}