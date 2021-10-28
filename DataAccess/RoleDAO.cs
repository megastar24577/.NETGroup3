using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;

namespace DataAccess
{
    public class RoleDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Role> GetRoles()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Roles.ToList();
            }
        }

        public Role GetRoleIdByRoleName(string roleName)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Roles
                    .SingleOrDefault(role => role.RoleName == roleName);
            }
        }
    }
}