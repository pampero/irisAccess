﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Model.Repositories.Interfaces
{
    public interface IGenericUpdatableRepository<T>
    {
        IQueryable<T> Query();

        IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        T GetByID(object id);
        void Insert(T entity);
        void Delete(object id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        IEnumerable<T> GetWithRawSql(string query, params object[] parameters);
    }
}