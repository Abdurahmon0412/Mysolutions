using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_3
{
    public class BankAccount
    {
        public string Firstname;
        public string Lastname;
        public double Deposit = -20;

        public BankAccount(string firstname,string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public BankAccount(string firstname, string lastname,double deposit)
            :this(firstname,lastname)
        {
            if(deposit > 0)
            {
                Deposit = deposit;

            }
            else
            {
                throw new Exception("pul tula ukam");
            }
        }

        public override string ToString()
        {
            return $"{Firstname}{Lastname}{Deposit}";
        }
            
        
    }
}
