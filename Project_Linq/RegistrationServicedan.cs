using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Linq
{
    public class RegistrationServicedan
    {
        private List<User> _users;
        public RegistrationServicedan()
        {
            _users = new List<User>();
        }

        public void Register(string emailaddress, string password)
        {
            var newuser = new User(password, emailaddress);
            var contains = _users.Any(u => u.EmailAddress == emailaddress );
            if( !contains )
            {
                _users.Add(new User(emailaddress, password));
                return;
            }
            Console.WriteLine("Bu email address allaqachon bor");

        }
        public bool Login (string emailaddress, string password)
        {
            var user = _users.FirstOrDefault(user => user.EmailAddress == emailaddress);
            if( user == null)
                Console.WriteLine("USer topilmadi");
            if(!user.IsEmailVerified )
            {
                Console.WriteLine("Sorry, you haven't verified your email address / phone number");
                return false;
            }
            if (!user.IsPhoneVerified)
            {
                Console.WriteLine("Sorry, you haven't verified your email address / phone number");
                return false;
            }
            return true;
        }
    }
}
