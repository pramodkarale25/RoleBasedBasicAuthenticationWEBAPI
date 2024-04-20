using System.Collections.Generic;

namespace RoleBasedBasicAuthenticationWEBAPI.Models
{
    public class UsersBL
    {
        public List<User> GetUsers()
        {
            // In Realtime you need to get the data from any persistent storage
            // For Simplicity of this demo and to keep focus on Basic AuthenticationD:\Study\Projects\RoleBasedBasicAuthenticationWEBAPI\RoleBasedBasicAuthenticationWEBAPI\Models\UserBL.cs
            // Here we are hardcoded the data

            List<User> userList = new List<User>();

            userList.Add(new User()
            {
                ID = 101,
                UserName = "AdminUser",
                Password = "123456",
                Roles = "Admin",
                Email = "Admin@a.com"
            });

            userList.Add(new User()
            {
                ID = 102,
                UserName = "BothUser",
                Password = "abcdef",
                Roles = "Admin,Superadmin",
                Email = "BothUser@a.com"
            });

            userList.Add(new User()
            {
                ID = 103,
                UserName = "SuperadminUser",
                Password = "Password@123",
                Roles = "Superadmin",
                Email = "Superadmin@a.com"
            });
            return userList;
        }
    }
}