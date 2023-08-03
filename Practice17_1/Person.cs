using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice17_1
{
    public class Person
    {
        public Guid Id { get; init; }
        public string Shortname { get; private set; }
        public string Fullname { get; private set; }
        public DateOnly Dateofbrith { get; init; }
        public string Details { get; set; }
        public string Address { get; set; }
        public int Money { get; set; }

        public Person(string shortname, string fullname,DateOnly dateofbirth)
        {
            Id = Guid.NewGuid();
            Shortname = shortname;
            Fullname = fullname;
            Dateofbrith = dateofbirth;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} ");
            Console.WriteLine($"Shortname{Shortname}");
            Console.WriteLine($"Fullname{Fullname}");
            Console.WriteLine($"DateofBirth{Dateofbrith}");
            Console.WriteLine($"Shortname{Details}");
            Console.WriteLine($"Details{Address}");
            Console.WriteLine($"{Money}");

        }


    }
}
