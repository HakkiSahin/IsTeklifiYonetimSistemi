using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.BLL.Abstract
{
    interface IUserAccountService :IServiceBase<UserAccount>
    {
		UserAccount Get(string mail, string sifre);
		bool DeleteByID(int entityID);

	}
}
