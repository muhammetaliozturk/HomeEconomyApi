using HomeEconomyApi.Infrastructure.Data;
using HomeEconomyApi.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HomeEconomyApi.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal HomeEconomyDBContext transmitterDBContext;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(HomeEconomyDBContext transmitterDBContext)
        {
            this.transmitterDBContext = transmitterDBContext;
            this.dbSet = transmitterDBContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Where(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

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

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Create(TEntity entity)
        {
            dbSet.Add(entity);
            transmitterDBContext.SaveChanges();
        }

        public virtual void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (transmitterDBContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }

            dbSet.Remove(entity);
            transmitterDBContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            transmitterDBContext.Entry(entity).State = EntityState.Modified;
            transmitterDBContext.SaveChanges();
        }
    }
}
