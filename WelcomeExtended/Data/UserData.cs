using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {

        private List<User> _users;
        private int _nextId;

        public UserData( )
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser( User user )
        {
            _nextId++;
            _users.Add( user );
        }

        public void DeleteUser( User user )
        {
            _users.Remove( user );
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Passwords == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Passwords == password)
                .FirstOrDefault() != null ? true : false;

        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Names == name && user.Passwords == password
                      select user.Id;
            return ret != null ? true : false;

        }

        public User GetUser(string name, string password )
        {
            return _users.Where(x => x.Names == name && x.Passwords == password)
                .FirstOrDefault();
        }

        public void SetActive(string name , DateTime date)
        {
            User user = _users.Where(x => x.Names == name).FirstOrDefault();
            user.Expires = date;
        }

        public void AssignUserRole(string name , UserRolesEnum role)
        {
            User user = _users.Where(x => x.Names == name).FirstOrDefault();
            user.Roles = role;
        }

    }
}
