using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13_1
{
    public class OptimizedGameEngine : GameEngine
    {
        public OptimizedGameEngine(string hero1,string hero2, string hero3) 
        {
            Display();
            Console.WriteLine("Bu qushilgandan sung");
            HeroList.Add(new Hero(hero1));
            HeroList.Add(new Hero(hero2));
            HeroList.Add(new Hero(hero3));
            Display();
        }
    }
}