using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_2
{
    public class User
    {

        public string Name;
        public string FirstName;
        public string LastName;

        public User(string name,string firstnaem, string lastname) 
        {
            this.Name = name;
            this.FirstName = firstnaem;
            this.LastName = lastname;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + FirstName.GetHashCode()+ Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is  User user)
            {
                return this.GetHashCode() == user.GetHashCode();

            }
            return false;
        }
    }
}
