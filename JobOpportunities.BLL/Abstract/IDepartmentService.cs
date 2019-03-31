using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
	public interface IDepartmentService:IServiceBase<Department>
	{
		Department GetByID(int departmentID);
	}
}
