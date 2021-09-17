using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Repository.Base
{
    public interface IRepository<TEntity, TPrimaryKey>
    {
        // CRUD : Create Read Update Delete

        Task Create(TEntity entity);

        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(TPrimaryKey id);

        Task Update(TEntity entity);

        Task Delete(TPrimaryKey id);

        Task<TPrimaryKey> CreateRnID(TEntity entity);

        void CreateNonAsync(TEntity entity);
    }

    public interface IRepository<TEntity> : IRepository<TEntity, int>
    {

    }
}
