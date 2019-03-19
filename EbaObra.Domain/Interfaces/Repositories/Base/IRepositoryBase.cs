using System;
using System.Linq;
using System.Threading.Tasks;

namespace EbaObra.Domain.Interfaces.IRepositories.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(Guid id);

        Task Create(TEntity entity);

        Task Update(Guid id, TEntity entity);

        Task Delete(Guid id);
    }
}