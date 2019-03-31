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
	public class ContractBLL : IContractService
	{
		EFContractDAL _contractDAL;
		public ContractBLL()
		{
			_contractDAL = new EFContractDAL();
		}

		public bool Delete(Contract entity)
		{
			return _contractDAL.Remove(entity) > 0;
		}

		public ICollection<Contract> GetAll()
		{
			return _contractDAL.GetAll();
		}

		public Contract GetByID(int contractID)
		{
			return _contractDAL.Get(a => a.ContractID == contractID);
		}

		public bool Insert(Contract entity)
		{
			return _contractDAL.Add(entity) > 0;
		}

		public bool Update(Contract entity)
		{
			return _contractDAL.Update(entity) > 0;
		}
	}
}
