using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
    public interface IClanService:IServiceBase<Clan>
    {
        Clan GetClanByStringID(string clanID);
		ICollection<Clan> GetAllClanByDepartmentID(int departmentID);
		ICollection<Clan> GetAllClanByContractID(int contractID);
        bool DeleteByID(string clanID);
    }
}
