using JobOpportunities.BLL.Abstract;
using JobOpportunities.DAL.Concrete.EntityFramework.DAL;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Concrete
{
	public class DepartmentBLL : IDepartmentService
	{
		EFDepartmentDAL _departmentDAL;
		public DepartmentBLL()
		{
			_departmentDAL = new EFDepartmentDAL();
		}

		public bool Delete(Department entity)
		{
			return _departmentDAL.Remove(entity)>0;
		}

		public ICollection<Department> GetAll()
		{
			return _departmentDAL.GetAll();
		}

		public Department GetByID(int departmentID)
		{
			return _departmentDAL.Get(a => a.DepartmentID == departmentID);
		}

		public bool Insert(Department entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(Department entity)
		{
			throw new NotImplementedException();
		}
	}
}
