using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SklepMai.Domain.Models;

namespace SklepMai.Core.Tests
{
    public class ProductsList : List<ProductDto>
    {
        public void GenerateRandomProducts(int count)
        {
            this.Clear();

            Random random = new Random();

            string[] names = { "Product A", "Product B", "Product C", "Product D", "Product E" };
            string[] descriptions = { "Description 1", "Description 2", "Description 3", "Description 4", "Description 5" };
            string[] imageUrls = { "url1", "url2", "url3", "url4", "url5" };

            for (int i = 0; i < count; i++)
            {
                ProductDto product = new ProductDto
                {
                    Id = i + 1,
                    Name = names[random.Next(names.Length)],
                    Description = descriptions[random.Next(descriptions.Length)],
                    ImageUrl = imageUrls[random.Next(imageUrls.Length)],
                    Price = (decimal)(random.Next(100, 1000)) / 10, // Cena losowa z zakresu 10 - 100
                    IsAvailable = random.Next(2) == 0 // Losowa dostępność produktu
                };

                this.Add(product);
            }

        }
    }
}