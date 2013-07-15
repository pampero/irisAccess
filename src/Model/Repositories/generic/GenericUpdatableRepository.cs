using Model.Helpers;
using Model.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Model
{
    public class SortExpression<TEntity, TType>
    {
        Expression<Func<TEntity, TType>> SortProperty;
    }

    public class GenericUpdatableRepository<TEntity> : IGenericUpdatableRepository<TEntity> where TEntity : AbstractUpdatableClass
    {
        internal AppDbContext context;
        internal DbSet<TEntity> dbSet;
        
        public GenericUpdatableRepository(AppDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet.AsNoTracking()
                .Where(q => !q.IsDeleted);

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IQueryable<TEntity> Query()
        {
            return dbSet.Where(x => !x.IsDeleted).AsNoTracking();
        }

        public virtual TEntity GetByID(object id)
        {     
            return dbSet.Find(id);
        }

        public virtual TEntity GetDetachedByID(object id)
        {
            var _id = Convert.ToInt32(id);
            return dbSet.AsNoTracking().First(x => x.ID == _id);            
        }

        public virtual void Insert(TEntity entity)
        {
            entity.Created = DateTime.Now;
            entity.CreatedBy = UserHelper.GetCurrentUser();

            dbSet.Add(entity);
            context.SaveChanges();
        }

        public virtual void Delete(object id)
        {
            var entityToDelete = dbSet.Find(id);

            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            entityToDelete.IsDeleted = true;
            entityToDelete.LastUpdated = DateTime.Now;
            entityToDelete.LastUpdatedBy = UserHelper.GetCurrentUser();

            var entry = context.Entry(entityToDelete);

            if (entry.State == EntityState.Detached)
            {
                var attachedEntity = dbSet.Find(entityToDelete.ID);

                if (attachedEntity != null)
                {
                    context.Entry(attachedEntity).CurrentValues.SetValues(entityToDelete);
                }
            }
            else
            {
                entry.CurrentValues.SetValues(entityToDelete);
                entry.State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            entityToUpdate.LastUpdated = DateTime.Now;
            entityToUpdate.LastUpdatedBy = UserHelper.GetCurrentUser();

            var entry = context.Entry(entityToUpdate);

            if (entry.State == EntityState.Detached)
            {
                var attachedEntity = dbSet.Find(entityToUpdate.ID);

                if (attachedEntity != null)
                {
                    context.Entry(attachedEntity).CurrentValues.SetValues(entityToUpdate);
                    entry.State = EntityState.Modified;
                }
            }
            else
            {
                entry.CurrentValues.SetValues(entityToUpdate);
                entry.State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.SqlQuery(query, parameters).ToList();
        }
    }
}