using EbaObra.Domain.Interfaces.IRepositories.Base;
using EbaObra.Infra.Persistence.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EbaObra.Infra.Persistence.Repositories.Base
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly Context dbContext = new Context();

        protected RepositoryBase(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsNoTracking();
        }


        public async Task<TEntity> GetById(Guid id)
        {
            return await dbContext.Set<TEntity>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync();
        }

        public async Task Create(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Guid id, TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
