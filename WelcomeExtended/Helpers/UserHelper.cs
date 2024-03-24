using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Data;
using Welcome.Model;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ConvertToString (this User user)
        { 
            StringBuilder sb = new StringBuilder ();
            sb.Append ("User{\n");
            sb.Append ($"Name: {user.Names},\n");
            sb.Append ($"Role:{user.Roles},\n");
            sb.Append ("}");

            return sb.ToString ();
        }

        public static bool ValidateCredentials(this UserData data , string name , string password)
        {
            if(name == null || name =="")
            {
                throw new Exception(" The {name} can t be empty");

            }
            if(password == null || password == "")
            {
                throw new Exception("The {password} can t be empty too");

            }

            return data.ValidateUser(name, password);
        }

        public static User GetUser(this UserData data,string name, string password)
        {
            return data.GetUser(name, password);
        }
    }
}

