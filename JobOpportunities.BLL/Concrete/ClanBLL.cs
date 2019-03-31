using JobOpportunities.BLL.Abstract;
using JobOpportunities.DAL.Abstract;
using JobOpportunities.DAL.Concrete.EntityFramework.DAL;
using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Concrete
{
    public class ClanBLL : IClanService
    {
        EFClanDAL _clanDAL;

        public ClanBLL()
        {
            _clanDAL = new EFClanDAL();
        }
		public bool Insert(Clan clan)
		{
			return _clanDAL.Add(clan) > 0;
		}

		public bool Update(Clan clan)
		{
			return _clanDAL.Update(clan) > 0;
		}
		public bool Delete(Clan clan)
        {
            return _clanDAL.Remove(clan) > 0;
        }
		public Clan GetClanByID(int clanID)
		{
			return _clanDAL.Get(a => a.ClanID == clanID);
		}

		public ICollection<Clan> GetAll()
		{
			return _clanDAL.GetAll();
		}
		public ICollection<Clan> GetAllClanByDepartmentID(int departmentID)
		{
			return _clanDAL.GetAll(a=> a.DepartmentID == departmentID);
		}

		public ICollection<Clan> GetAllClanByContractID(int contractID)
		{
			return _clanDAL.GetAll(a => a.ContractID == contractID);
		}

		public bool DeleteByID(int clanID)
        {
            Clan clan = _clanDAL.Get(a => a.ClanID == clanID);
            return _clanDAL.Remove(clan) > 0;
        }

		public Clan GetClanByStringID(string clanID)
		{
			throw new NotImplementedException();
		}

		

		public bool DeleteByID(string clanID)
		{
			throw new NotImplementedException();
		}
	}
}
