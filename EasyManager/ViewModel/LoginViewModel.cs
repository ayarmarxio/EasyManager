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

        public string CurrentUserName { get; set; }
        public string CurrentUserPassword { get; set; }

        public RelayCommand loginCommand { get; set; }

        public ObservableCollection<Member> MemberCollection { get; set; }
        
        public LoginViewModel()
        {
            // loginCommand = new RelayCommand();
            _memberCollection = _memberCatalogSingleton.GetMemberCatalogSingleton();

        }



    }
}
