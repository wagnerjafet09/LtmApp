using LtmApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LtmApp.DAL.Core
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly LtmContext context;
        private readonly DbSet<TEntity> myDbSet;

        public RepositoryBase(LtmContext context)
        {
            this.context = context;
            this.myDbSet = this.context.Set<TEntity>();
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.myDbSet.Any(filter);
        }

        public virtual List<TEntity> GetEntities()
        {
            return this.myDbSet.ToList();
        }
        public virtual TEntity GetEntity(int id)
        {
            return this.myDbSet.Find(id);
        }

        public virtual void remove(TEntity entity)
        {
            this.myDbSet.Remove(entity);
        }
        public virtual void remove(TEntity[] TEntities)
        {
            this.myDbSet.RemoveRange(TEntities);
        }

        public virtual void save(TEntity entity)
        {
            this.myDbSet.Add(entity);
        }
        public virtual void save(TEntity[] TEntities)
        {
            this.myDbSet.AddRange(TEntities);
        }

        public virtual void update(TEntity entity)
        {
            this.myDbSet.Update(entity);
        }
        public virtual void update(TEntity[] entities)
        {
            this.myDbSet.UpdateRange(entities);
        }

        public virtual void saveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
