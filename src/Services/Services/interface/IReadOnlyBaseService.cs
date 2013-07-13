using System;
using System.Collections.Generic;
using System.Linq;
using Model;


namespace Services.interfaces
{
    public interface IReadOnlyBaseService<TEntity>
    {
        IList<TEntity> GetAll();
        IQueryable<TEntity> List();
        TEntity GetById(int objectId);
    }
}