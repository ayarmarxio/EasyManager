using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    class User
    {
        // Fields of the User
        private string _userName;
        private string _userPassword;


        // Properties of the User
        public string UserName { get; set; }
        public string UserPassword { get; set; }


        // Constructor of the user
        public User(string userName, string userPassword)
        {
            _userName = userName;
            _userPassword = userPassword;
        }

        public User()
        {
            
        }

    }
}
