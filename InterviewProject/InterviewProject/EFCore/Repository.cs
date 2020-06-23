using InterviewProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.EFCore
{
   public abstract class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity: class, IEntity
        where TContext: DbContext
    {
        private readonly TContext context;
        private readonly DbSet<TEntity> entities;
        public Repository(TContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            entities.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await entities.FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            entities.Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
