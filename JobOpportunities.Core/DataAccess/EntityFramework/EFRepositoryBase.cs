using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Core.DataAccess.EntityFramework
{
    public class EFRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
      where TEntity : class, IEntity, new()
      where TContext : DbContext, new()
    {

        TContext ctx;

        public EFRepositoryBase()
        {
            ctx = new TContext();
        }

        public int Add(TEntity entity)
        {
            //ctx.Set<TEntity>().Add(entity);
            ctx.Entry(entity).State = EntityState.Added;
            return ctx.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return ctx.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return ctx.Set<TEntity>().ToList();
            }
            else
            {
                return ctx.Set<TEntity>().Where(filter).ToList();
            }
        }

        public int Remove(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Deleted;
            return ctx.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            return ctx.SaveChanges();
        }
    }
}
