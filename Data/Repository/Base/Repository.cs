using Gimli.Data.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Repository.Base
{
    public class Repository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity:Entity<TPrimaryKey>
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(TPrimaryKey id)
        {
            var entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(TPrimaryKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
             _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TPrimaryKey> CreateRnID(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public void CreateNonAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);

           _dbContext.SaveChanges();
        }

    }

    public class Repository<TEntity>:Repository<TEntity, int>, IRepository<TEntity> where TEntity : Entity<int>
    {

        public Repository(ApplicationDbContext dbContext) :base(dbContext)
        {
            
        }
    }
}
