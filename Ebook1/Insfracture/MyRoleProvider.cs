using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Ebook1.Models;

namespace Ebook1.Insfracture
{
    public class MyRoleProvider : System.Web.Security.RoleProvider
    {
        public override string ApplicationName { get; set; }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (Ebook1Context objContext = new Ebook1Context())
            {
                var objUser = objContext.User.FirstOrDefault(x => x.Email == Name);

                if (objUser == null)
                {
                    return null;
                }
                else
                {
                    //var roleid = objContext.UserAndRoles.FirstOrDefault(x => x.UserId == objUser.ID).RoleId;
                    //int Role_id = Convert.ToInt32(roleid);

                    string[] ret = objContext.UserAndRole.Where(x => x.user_id == objUser.ID).Select(x => x.role_name).ToArray();

                    return ret;
                }
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}