using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_2
{
    public class UltimatePlanner :Planner
    {
        public Dictionary<string, DateOnly> KalendarEvent = new Dictionary<string, DateOnly>();
        public override void Add(string name, TimeOnly time)
        {
            bool a = false;
            foreach(var item in Events)
            {
                if(time == item.Value)
                {
                    a = true;
                    Console.WriteLine("You have conflict in daily plan");
                }
            }
            if(!a)
            {
                Events.Add(name,time);
            }
        }
        public void Add(string name, DateOnly date)
        {
            KalendarEvent.Add(name, date);
        }

        public override void Display()
        {
            base.Display();
            foreach(var item in KalendarEvent)
            {
                Console.WriteLine($"EventName: {item.Key} - EventsTime: {item.Value}");

            }
        }

    }
}
