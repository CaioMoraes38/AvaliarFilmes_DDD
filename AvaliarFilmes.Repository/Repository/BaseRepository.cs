using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AvaliarFilmes.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlContext;

        public BaseRepository(MySqlContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public void AttachObject(object obj)
        {
            _mySqlContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity entity)
        {
            _mySqlContext.Set<TEntity>().Add(entity);
            _mySqlContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _mySqlContext.Entry(entity).State = EntityState.Modified;
            _mySqlContext.SaveChanges();
        }

        public void Delete(object id)
        {
            _mySqlContext.Set<TEntity>().Remove(Select(id));
            _mySqlContext.SaveChanges();
        }

        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlContext.Set<TEntity>().AsNoTracking().AsQueryable();
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _mySqlContext.Set<TEntity>().AsNoTracking().AsQueryable();
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }
    }
}