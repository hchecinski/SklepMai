using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepMai.Domain.Models
{
    public class ProductDto : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal? Price { get; set; } = null;

        public override string ToString()
        {
            return $"Id: {Id}, Name: '{Name}', Description: '{Description}', Price: {Price};";
        }
    }
}