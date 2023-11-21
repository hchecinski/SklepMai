using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepMai.Domain.Models
{
    public class Entity
    {
        public int Id { get; set; } = -1;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
    }
}