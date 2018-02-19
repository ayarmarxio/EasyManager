using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyManager.Common;
using EasyManager.Model;

namespace EasyManager.ViewModel
{
    class LoginViewModel: NotifyPropertyChanged
    {
        MemberCatalogSingleton _memberCatalogSingleton = MemberCatalogSingleton.Instance;
        private ObservableCollection<Member> _memberCollection;
        private LoginHandler _loginHandler;
        
        public string CurrentUserName { get; set; }
        public string CurrentUserPassword { get; set; }

        public RelayCommand loginCommand { get; set; }

        public ObservableCollection<Member> MemberCollection {
            get
            {
                return _memberCollection;
            }
            set
            {
                _memberCollection = value;
            }
            
        }
        
        public LoginViewModel()
        {

            
            _loginHandler = new LoginHandler(this);
            loginCommand = new RelayCommand(_loginHandler.AdminLoginCheck);
            _memberCollection = _memberCatalogSingleton.GetMemberCatalogSingleton();


        }



    }
}
