using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_3
{
    public class SecureBankAccount : BankAccount
    {
        public string passphrase;
        public SecureBankAccount(string firstname, string lastname, double deposit)
            :base(firstname, lastname,deposit) 
        {

        }

        public SecureBankAccount(string firstname, string lastname, double deposit,string passportSerie)
            : base(firstname, lastname, deposit)
        {
            passphrase = passportSerie;
        }

        public override string ToString()
        {
            return $"{Firstname}{Lastname}{Deposit}{passphrase}";
        }
    }
}
