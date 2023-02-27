using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LtmApp.DAL.Core
{
    public interface IRepositoryBase<TEntity> where TEntity: class
    {
        void save (TEntity entity);
        void save(TEntity[] TEntities);

        void update(TEntity entity);
        void update(TEntity[] entities);

        void remove (TEntity entity);
        void remove(TEntity[] TEntities);

        TEntity GetEntity(int id);

        List<TEntity> GetEntities();

        bool Exists(Expression<Func<TEntity, bool>>filter);

        void saveChanges();
    
    }
    
}
