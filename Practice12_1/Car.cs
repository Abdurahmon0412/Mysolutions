using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12_1
{
    public class Car
    {
        public string Name;
        public string Brand;
        public Car(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()+ Brand.GetHashCode() ;

        }

        public override bool Equals(object? obj)
        {
            if (obj is  Car car )
            {
                return this.GetHashCode() == car.GetHashCode() ;

            }
            return false;
        }
    }
}
