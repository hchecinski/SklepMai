using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SklepMai.Domain.Models;
using SklepMai.Domain.Repositories;

namespace SklepMai.Core.Tests
{
    public class ProductRepository : IProductRepository
    {
        public ProductsList List {get;} = new ProductsList();

        public ProductRepository()
        {
            List.GenerateRandomProducts(5);
        }

        public Task<int> AddItem(ProductDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetAllItems()
        {
            return await Task.FromResult(List);
        }

        public Task<ProductDto> GetItemById(int id)
        {
            //return await Task.FromResult(List.FirstOrDefault(i => i.Id == id));
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItem(ProductDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsProductNameAlreadyExist(string productName)
        {
            throw new NotImplementedException();
        }
    }
}