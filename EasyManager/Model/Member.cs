using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyManager.Model
{
    class Member: User
    {
        
        private int _id;
        private string _phoneNumber;
        private string _address;
        private string _city;
        private string _email;
        private int _wheight;
        private int _height;


        // Constructor of the Member Inherit from the User UserName and Password
        public Member(string userName, string userPassword, int id, string phoneNumber, string address, string city, string email, int weight, int height) : base(userName, userPassword)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            Email = email;
            Wheight = weight;
            Height = height;
        }

        public Member()
        {
            
        }

        


        public int Id { get => _id; set => _id = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Email { get => _email; set => _email = value; }
        public int Wheight { get => _wheight; set => _wheight = value; }
        public int Height { get => _height; set => _height = value; }
    }
}
