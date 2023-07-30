using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11_T1
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string firstname, string lastname, string email,string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {PhoneNumber} {Email}";
        }
    }
}
