using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_1
{
    public class Hero
    {
        public Guid Id;

        public string Name;

        public Hero(string heroName) 
        {
            Id = Guid.NewGuid();
            Name = heroName;
        }

        public override string ToString()
        {
            return $"Id: {Id}  Name: {Name}";
        }


    }
}
