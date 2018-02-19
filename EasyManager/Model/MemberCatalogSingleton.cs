using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    class MemberCatalogSingleton
    {
        private static MemberCatalogSingleton instance;

        private ObservableCollection<Member> memberCollection;

        public MemberCatalogSingleton()
        {
            memberCollection = new ObservableCollection<Member>()
            {
                new Member("Admin", "haltandcatchfire", 0001, "45 50271146", "Store Valbyvej 21, Himmelev", "Roskilde","ayarmarxio@gmail.com", 75, 170),
                new Member("Gordon", "clark1", 0002, "45 98376532", "Store Valbyvej 21, Himmelev", "San Francisco","fgdes@gmail.com", 70, 170),
                new Member("Cameron", "howe", 0003, "45 20935567", "Store Valbyvej 21, Himmelev", "San Francisco","fdgfd@gmail.com", 55, 170),
                new Member("Donna", "clark2", 0004, "45 21218736", "Store Valbyvej 21, Himmelev", "Silicon Valley","gdfhg@gmail.com", 57, 160),
                new Member("Joe", "mcmillan", 0005, "45 23899888", "Store Valbyvej 21, Himmelev", "Silicon Valley","gdfg@gmail.com", 80, 180),
                new Member("Diane", "gould", 0006, "45 89888223", "Store Valbyvej 21, Himmelev", "Los Angeles","hgjhjjhg@gmail.com", 60, 168),
                new Member("Malcolm", "levitan", 0007, "45 27276352", "Store Valbyvej 21, Himmelev", "Los Angeles","hjfgdjgdf@gmail.com", 55, 167),
                new Member("Haley", "clark3", 0008, "45 87653426", "Store Valbyvej 21, Himmelev", "Silicon Valley","gfhjdjgdf@gmail.com", 56, 165),
            };
        }



        public static MemberCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MemberCatalogSingleton();
                }
                return instance;

            }

        }

        public ObservableCollection<Member> GetMemberCatalogSingleton()
        {
            return memberCollection;
        }

    }
}
