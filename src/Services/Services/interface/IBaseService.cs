using System;
using System.Collections.Generic;
using System.Linq;


namespace Services.interfaces
{
    public interface IBaseService<TEntity>
    {
        IList<TEntity> GetAll();
        IQueryable<TEntity> Query();
        TEntity GetById(int objectId);
        void Delete(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity entity);
    }
}