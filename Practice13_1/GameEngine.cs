namespace Practice13_1
{
    public class GameEngine
    {
        public List<Hero> HeroList = new List<Hero>()
        {
            new Hero("Yurnero"),
            new Hero("Sven"),
            new Hero("Tiny")

        }; 
        public void Display()
        {
            foreach (var hero in HeroList)
            {
                Console.WriteLine(hero.ToString());
            }
        }

    }
}