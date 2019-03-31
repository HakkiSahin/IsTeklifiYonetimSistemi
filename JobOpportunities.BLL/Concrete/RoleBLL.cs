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
    public class RoleBLL : IRoleService
    {
        EFRoleDAL _roleDAL;

        public RoleBLL()
        {
            _roleDAL = new EFRoleDAL();
        }
        public bool Delete(Role role)
        {

            return _roleDAL.Remove(role) > 0;
        }

        public bool DeleteByID(int roleID)
        {
            Role role = _roleDAL.Get(a => a.RoleID == roleID);
            return _roleDAL.Remove(role) > 0;
        }

        public Role Get(int roleID)
        {
            return _roleDAL.Get(a => a.RoleID == roleID);
        }

        public ICollection<Role> GetAll()
        {
            return _roleDAL.GetAll();
        }

        public bool Insert(Role role)
        {
            return _roleDAL.Add(role) > 0;
        }

        public bool Update(Role role)
        {
            return _roleDAL.Update(role) > 0;
        }
    }
}
