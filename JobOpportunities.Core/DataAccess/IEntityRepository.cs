using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Core.DataAccess
{
    public interface IEntityRepository<TEntity>
        where TEntity : IEntity
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Remove(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
