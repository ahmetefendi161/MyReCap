using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected TContext context;
        

        public EfEntityRepositoryBase(TContext context)
        {
            this.context = context;
        }

        public void Add(TEntity entity)  
        {
            
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
          
                
            
            
        }

        public void Update(TEntity entity)
        {
            
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                
            
        }

        public void Delete(TEntity entity)
        {
            
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            
                return context.Set<TEntity>().SingleOrDefault(filter);

            
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            
        }
        

    }
}
