using Naxxum.JobyHunter.Authentication.Domain.Repositories;
using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private AppIdentityContext _context = null; 
        private DbSet<TEntity> _entity;
        public Repository(AppIdentityContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }
        public async ValueTask<TEntity> AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async ValueTask<TEntity> Read(string EntityId) =>
             await _entity.FindAsync(EntityId);

        public async ValueTask<IEnumerable<TEntity>> ReadAll() =>
            await _entity.ToListAsync();

        public void UpdateAsync(TEntity entity) =>
            _entity.Attach(entity);

        public async ValueTask DeleteAsync(string entityId)
        {
            var oData = await _entity.FindAsync(entityId);
            _entity.Remove(oData);
        }

        public int SaveChanges() =>
            _context.SaveChanges();
    }
}
