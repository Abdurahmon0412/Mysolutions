using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N14_3
{
    public class Validator
    {
        private Regex _forFullName = new Regex("^[a-zA-Z'-]+$");
        private Regex _forEmail = new Regex("^[a-zA-Z0-9._%+-] +@[a-zA-Z0-9.-] +\\.[a-zA-Z] { 2,}$");
        private Regex _forPhoneNumber = new Regex("^\\+?\\d{1,3}?[-.\\s]?\\(?\\d{1,4}\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

        public bool IsValidName(string name)
        {
            return _forFullName.IsMatch(name);
        }

        public bool IsValidEmail(string email)
        {
            return _forEmail.IsMatch(email);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return _forPhoneNumber.IsMatch(phoneNumber);        
        }

    }
}
