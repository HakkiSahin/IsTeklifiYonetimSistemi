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
    public class UserAccountBLL : IUserAccountService
    {
        EFUserAccountDAL _userAccountDAL;
        public UserAccountBLL()
        {
            _userAccountDAL = new EFUserAccountDAL();
        }

        public bool Delete(UserAccount userAccount)
        {
            return _userAccountDAL.Remove(userAccount) > 0;
        }

        public bool DeleteByID(int userAccountID)
        {
            UserAccount userAccount = _userAccountDAL.Get(a => a.UserAccountID == userAccountID);
            return _userAccountDAL.Remove(userAccount) > 0;
        }

        public UserAccount Get(int userAccountID)
        {
            return _userAccountDAL.Get(a => a.UserAccountID == userAccountID);
        }

        public UserAccount Get(string mail, string sifre)
        {
            UserAccount user = null;
            user = _userAccountDAL.Get(a => a.Mail == mail);
            if (user != null)
            {
                if (user.Password == sifre)
                {
                    return user;
                }
            }
            
            return null;
        }

        public ICollection<UserAccount> GetAll()
        {
            return _userAccountDAL.GetAll();
        }

        public bool Insert(UserAccount userAccount)
        {
            return _userAccountDAL.Add(userAccount) > 0;
        }

        public bool Update(UserAccount userAccount)
        {
            return _userAccountDAL.Update(userAccount) > 0;
        }
    }
}
