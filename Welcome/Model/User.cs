using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {

        string Name;
        string Password;
        UserRolesEnum Role;
        int id;
        DateTime expires;

        public string Names 
        {
            get { return Name; }
            set { Name = value; }
        
        }

        public string Passwords
        {
            get { return Password; }
            set { Password = value; }

        }

        public UserRolesEnum Roles
        {
            get { return Role; }
            set { Role = value; }

        }

        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public DateTime Expires
        {
            get { return expires; }
            set { expires = value; }

        }

    }
}
