using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.ViewModel
{
    class LoginHandler
    {

        private LoginViewModel _loginViewModel;

        public LoginHandler(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }


        public void AdminLoginCheck()
        {

            foreach (var COLLECTION in _loginViewModel.MemberCollection)
            {
                if (_loginViewModel.CurrentUserName == "admin" && _loginViewModel.CurrentUserPassword == "haltandcatchfire")
                {

                }
                // else if (_loginViewModel.CurrentUserName == _loginViewModel.
                {

                }
            }

            
        }

        


    }
}
