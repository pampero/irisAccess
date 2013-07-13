using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Security.Principal;


namespace Model
{
    public class SortExpression<TEntity, TType>
    {
        Expression<Func<TEntity, TType>> SortProperty;
    }

    public class GenericUpdatableRepository<TEntity> where TEntity : AbstractUpdatableClass
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
            IQueryable<TEntity> query = dbSet.AsNoTracking();

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

            dbSet.Add(entity);
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
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            entityToUpdate.LastUpdated = DateTime.Now;

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
        }

        public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
        {
            return dbSet.SqlQuery(query, parameters).ToList();
        }
    }
}