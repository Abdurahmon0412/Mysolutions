using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_3
{
    public class Validator
    {
        public string isvalidage {get;set;}
        public string isvalidfirstname {get;set;}
        public string isvalidlastname { get; set; }
        public string isvalidemailaddress { get; set; }
        public string isvalidphonenumber { get; set; }

        public Validator(string age, string firstname, string lastname,string emailaddress,string phonenumber) 
        {

        }

        public bool IsValidAge(string age)
        {
            return false;
        }

        public bool IsValidFirstName(string firstname)
        {
            return false;
        }

        public bool IsValidLastName(string lastName)
        {
            return false;
        }

        public bool IsValidEmailAddress(string emailaddress)
        {
            return false;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return false;
        }
    }
}
