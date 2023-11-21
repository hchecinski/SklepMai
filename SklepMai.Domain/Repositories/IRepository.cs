using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepMai.Domain.Repositories
{
    public interface IRepository<T> where T: class
    {
        Task<T> GetItemById(int id);
        Task<IEnumerable<T>> GetAllItems();
        Task AddItem(T item);
        Task UpdateItem(T item);
        Task DeleteItem(T item);
    }
}