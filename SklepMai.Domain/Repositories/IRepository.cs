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
        Task<int> AddItem(T item);
        Task<bool> UpdateItem(T item);
        Task<bool> DeleteItem(int id);
    }
}