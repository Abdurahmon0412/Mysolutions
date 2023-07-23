using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_1
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User(string firstname, string lastname, int age) 
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
        public string GetUser()
        {
            return $"User fields: \nFirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}";
        }
    }
}
