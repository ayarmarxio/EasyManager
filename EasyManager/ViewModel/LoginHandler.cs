using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using EasyManager.Common;
using EasyManager.Model;
using EasyManager.View;

namespace EasyManager.ViewModel
{
    class LoginHandler
    {

        private LoginViewModel _loginViewModel;
        private Member _memberLoginHandler;
        private readonly FrameNavigateClass _frame;
        MemberSingleton _memberSingleton = MemberSingleton.GetInstance();

       



        public LoginHandler(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
        }

        
        public async void AdminLoginCheck()
        {
            
            if (_loginViewModel.MemberCollection != null)
            { 
                foreach (var memberOfCollection in _loginViewModel.MemberCollection)
                {
                    if (_loginViewModel.CurrentUserName == "admin" && _loginViewModel.CurrentUserPassword == "haltandcatchfire")
                    {
                     
                        _frame.ActivateFrameNavigation(typeof(MainPage), memberOfCollection );
                    }
                    else if (_loginViewModel.CurrentUserName == _memberLoginHandler.UserName &&
                             _loginViewModel.CurrentUserPassword == _memberLoginHandler.UserPassword)
                    {
                      
                        _frame.ActivateFrameNavigation(typeof(MemberMenuPage), memberOfCollection);
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Sorry wrong input.");
                        await msg.ShowAsync();
                    }
                }
            }


        }

        

        


    }
}
