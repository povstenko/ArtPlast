using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StekloMaster
{
    class User
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
        }

        private string secondName;
        public string SecondName
        {
            get { return secondName; }
        }

        private string login;
        public string Login
        {
            get { return login; }
        }

        private string password;
        public string Password
        {
            get { return password; }
        }

        private string email;
        public string Email
        {
            get { return email; }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
        }

        public User()
        {
                
        }
        public User(int id, string firstName, string secondName, string login, string password, string email, bool isAdmin)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.login = login;
            this.password = password;
            this.email = email;
            this.isAdmin = isAdmin;
        }
        
        public override string ToString()
        {
            return $"{id} | {firstName} | {secondName} | {login} | {password} | {email} | {isAdmin}";
        }
    }
}