using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice10_3
{
    public class Validator
    {




        public bool IsValidAge(string age)
        {
            if(int.TryParse(age, out int value))
            {
                return true;
            }
            return false;
        }

        public bool IsValidFirstName(string firstname)
        {
            Regex firstnames = new Regex("^[a-zA-Z'-]+$");
            return firstnames.IsMatch(firstname);
        }

        public bool IsValidLastName(string lastName)
        {
            Regex lastNames = new Regex("^[a-zA-Z'-]+$");
            return lastNames.IsMatch(lastName);
        }


    public bool IsValidEmailAddress(string emailaddress)
        {
            Regex _forEmail = new Regex("^[a-zA-Z0-9._%+-] +@[a-zA-Z0-9.-] +\\.[a-zA-Z] { 2,}$");
            return _forEmail.IsMatch(emailaddress);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex _forPhoneNumber = new Regex("^\\+?\\d{1,3}?[-.\\s]?\\(?\\d{1,4}\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");
            return _forPhoneNumber.IsMatch(phoneNumber);
        }
    }
}
