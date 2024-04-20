using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstracts.Repositories.Base
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);
        Task<bool> IsExistAsync(Expression<Func<T, bool>> filter);
        Task<int> GetTotalCountAsync(Expression<Func<T, bool>>? filter = null);
        Task<IEnumerable<T>> GetPaginatedAsync(int page, int pageSize);





    }
}
