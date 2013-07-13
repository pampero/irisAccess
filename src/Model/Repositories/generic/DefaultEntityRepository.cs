using System.Data.Entity;

namespace Model
{
    public class DefaultEntityRepository<TEntity> : GenericUpdatableRepository<TEntity> where TEntity : DefaultEntity, new()
    {
        internal AppDbContext context;
        internal DbSet<TEntity> dbSet;

        public DefaultEntityRepository(AppDbContext context) : base(context)
        {
        }

        public virtual void Insert(string description)
        {
            TEntity entity = new TEntity();

            entity.Description = description;

            base.Insert(entity);
        }
    }
}