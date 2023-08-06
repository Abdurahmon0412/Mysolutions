using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice19_1
{
    public class Person
    {
        private string name { get; set; }
        private int age { get; set; }
        private string city { get; set; }
        private readonly string national;


        public Person() { Console.WriteLine("oddiy kons vorkd"); }

        public Person(string name, int age, string city, string national)
        {
            Console.WriteLine("paramezidetd kons vorkd");
            this.name = name;
            this.age = age;
            this.city = city;
            this.national = national;

        }

        public Person(Person person)
        {
            Console.WriteLine("kopy kons vorkd");
            this.name = person.name;
            this.age = person.age;
            this.city = person.city;
            this.national = person.national;
        }

        static Person()
        {
            Console.WriteLine("Static construktor is worked");
        }

        public override string ToString()
        {
            return $"{name} {age} {city} {national}";
        }
    }
}
