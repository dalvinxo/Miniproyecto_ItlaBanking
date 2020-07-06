using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    interface IRepository<T> where T : class
    {

        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    
    }


}
