using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HSPA.Models.EFCore
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly HSPAContext _hSPAContext;
        public GenericRepository(HSPAContext hSPAContext)
        {
            _hSPAContext = hSPAContext;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _hSPAContext.Set<TEntity>().AsNoTracking();
        }
        public async Task<TEntity> GetById(int id)
        {
            if(id > 0)
            {
                return await _hSPAContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            }
            return null;
        }

        public async Task Create(TEntity entity)
        {
            if (entity != null)
            {
                await _hSPAContext.Set<TEntity>().AddAsync(entity);
                await _hSPAContext.SaveChangesAsync();
            }
        }
        public async Task Update(int id, TEntity entity)
        {
            if (entity != null)
            {
                _hSPAContext.Set<TEntity>().Update(entity);
                await _hSPAContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            if (id > 0)
            {
                var entity = await _hSPAContext.Set<TEntity>().FindAsync(id);
                _hSPAContext.Set<TEntity>().Remove(entity);
                await _hSPAContext.SaveChangesAsync();
            }
        }
    }
}
