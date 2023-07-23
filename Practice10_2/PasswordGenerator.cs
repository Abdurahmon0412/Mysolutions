using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_2
{
    public class PasswordGenerator
    {
        Random rd = new Random();
        char[] numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        char[] symbols = new char[] { '!', '"', '#', '$', '%', '&', '\'','(',')','*','+',',','/','-','^' };
        List<string> password = new List<string>();
        public string Generate(bool hasDigits, bool hasLetters, bool hasSymbol, int length)
        {
            for (int i = 0; i <= length;)
            {
                if (hasDigits)
                {
                    password.Add(Convert.ToString(numbers[rd.Next(0, numbers.Length)]));
                    i++;
                }
                if (hasLetters)
                {
                    var r = rd.Next(0,2);
                    if (r == 1)
                    {
                        password.Add(Convert.ToString(Convert.ToChar(rd.Next(96, 122))));
                        i++;
                    }
                    if(r == 0)
                    {
                        password.Add(Convert.ToString(Convert.ToChar(rd.Next(65, 90))));
                    }
                }
                if (hasSymbol)
                {
                    i++;
                    password.Add(Convert.ToString(symbols[rd.Next(0, numbers.Length)]));
                }
                else { i++; }
            }
            try 
            {
                string pass = "";
                for (int i = length; i > 0; i--)
                {
                    for (int j = 0; j < password.Count - 1; j++)
                    {
                        var temp = password[j];
                        password[j] = password[i];
                        password[i] = temp;
                    }
                    pass += password[i];
                }

                return pass;
            }
            catch (Exception )
            {
                return "password not created";
            }
        }
    }

}
