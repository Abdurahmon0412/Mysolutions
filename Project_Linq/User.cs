using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Linq
{
    public class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }
        public User(string email, string password)
        {
            IsEmailVerified = false;
            IsPhoneVerified = false;
            EmailAddress = email;
            Password = password;
        }
    }
}
