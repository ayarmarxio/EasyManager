using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    class MemberSingleton
    {
        public static Member _member;

        //property
        private static MemberSingleton Instance { get; set; }

        //Constructor
        private MemberSingleton()
        {
            _member = new Member();
        }

        //method for getting the instance
        public static MemberSingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MemberSingleton();
            }
            return Instance;
        }

        //method of the business logic
        public void SetPerson(Member member)
        {
            _member = member;
        }
    }
}
