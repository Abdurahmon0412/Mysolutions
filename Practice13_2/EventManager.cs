using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_2
{
    public class EventManager
    {
        Dictionary<string,DateOnly> AddList1 = new Dictionary<string,DateOnly>();
        Dictionary<string, TimeOnly> AddList2 = new Dictionary<string, TimeOnly>();
    
        public void Add(string eventname,DateOnly eventdate)
        {
            AddList1.Add(eventname, eventdate);

        }

        public void Add(string eventname, TimeOnly eventdate)
        {
            AddList2.Add(eventname, eventdate);
        }


        public void Display()
        {
            foreach (var item in AddList2)
            {
                Console.WriteLine($"{item.Key} Sana: {item.Value}");
            }
            Console.WriteLine("sungi 3 kunligdagi! ");
            foreach (var item in AddList1)
            {
                if (item.Value.Day < 29)
                    Console.WriteLine($"{item.Key} Sana {item.Value}");
            }

        }

    }
}
