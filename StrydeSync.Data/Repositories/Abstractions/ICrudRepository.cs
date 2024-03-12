using StrideSync.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Repositories.Abstractions
{
    public interface ICrudRepository<T> 
        where T : BaseEntity
    {
        public Task AddAsync(T entity);
        public Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task UpdateAsync(T entity);
        public Task DeleteByIdAsync(int id);

    }
}
