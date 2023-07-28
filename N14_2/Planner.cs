using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_2
{
    public class Planner
    {
        public Dictionary<string , TimeOnly> Events = new Dictionary<string , TimeOnly>();
        public virtual void Add(string name,TimeOnly time)
        {
            Events.Add(name, time);
        }

        public virtual void Display()
        {
            foreach(var events in Events)
            {
                Console.WriteLine($"EventName: {events.Key} - EventsTime: {events.Value}");
            }
        }

    }
}
