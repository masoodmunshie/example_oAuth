using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTokenProject.Data
{
    public class UserMasterRepository: IDisposable
    {

        SecurityDB context = new SecurityDB();
        //This method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMasters.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }

        public void Dispose()
        {
           context.Dispose();
        }
    }
}