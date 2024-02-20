using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> Read(string entityId);
        ValueTask<IEnumerable<TEntity>> ReadAll();
        void UpdateAsync(TEntity entity);
        ValueTask DeleteAsync(string entityId);
        int SaveChanges();
    }
}
