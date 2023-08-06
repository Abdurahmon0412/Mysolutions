using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice18_1
{
    public abstract class Car
    {
        private string Brand { get; init; }
        private int Year { get; init; }
        private string Color { get; set; }

        public Car(string Brand, int year,string color)
        {
            this.Brand = Brand;
            this.Year = year;
        }
        public void Show()
        {
            Console.WriteLine($"{Brand} {Year} {Color}");
        }

        public abstract void Drive();

    }
}
