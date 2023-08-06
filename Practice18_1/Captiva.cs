using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice18_1;
namespace Practice18_1
{
    public  sealed class Captiva: Car
    {
        public static string Passengers { get; set; }
        public readonly int maxspeed;
        public Captiva(string Passangers, int year, string color) :
            base("Malibu", year, color)
        {
            this.maxspeed = 100;
        }


        public override void Drive()
        {
            var rd = new Random();
            var random = rd.Next(0, 1);
            while (random < 100)
            {
                Console.Clear();
                Thread.Sleep(3000);
                random = rd.Next(random, random + 5);
                Console.WriteLine(random);
            }
        }
    }
}
