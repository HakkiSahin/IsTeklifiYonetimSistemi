using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
	public interface IServiceBase<T>
		where T : IEntity
	{
		bool Insert(T entity);
		bool Delete(T entity);
		bool Update(T entity);
		ICollection<T> GetAll();
	}
}
