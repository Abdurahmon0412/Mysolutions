using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice19_1
{
    public class Person2
    {
        private Person2() { Console.WriteLine("Privite kons is worked"); }
        
            private static Person2 _instance;

            public static Person2 GetInstance()
            {
                if (_instance is null)
                    _instance = new Person2();

                return _instance;
            }

        
    }
}