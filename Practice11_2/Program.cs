using Practice11_2;

var MovieControl = new MovieLibrary();
bool exit = true;
while (exit)
{
    Console.WriteLine("display all - d / search by name - sn, search by genre - sg, search by review sr");
    var choose = Console.ReadLine().ToLower();
    switch (choose)
    {
        case "d":
            MovieControl.Display();
            break;
        case "sn":
            Console.WriteLine("Enter film name");
            var filmname = Console.ReadLine();
            MovieControl.SearchByName(filmname);
            break;
        case "sg":
            Console.WriteLine("Enter film ganre");
            var filmganre = Console.ReadLine();
            MovieControl.SearchByGenre(filmganre);
            break;
        case "sr":
            Console.WriteLine("Enter a score");
            double filmscore = 0D;
            bool score = true;
            do
            {
                try
                {
                    filmscore = Convert.ToDouble(Console.ReadLine());
                    if(filmscore > 10D)
                    {
                        Console.WriteLine(" invalid score, enter between 1 and 10");
                        filmscore = 0;
                    }
                    else
                    {
                        score = false;
                    }
                }
                catch(Exception)
                {
                    filmscore = 0D;
                    Console.WriteLine("this is exeption");
                }   
            }while (score);
            MovieControl.SearchByScoreHigherThan(filmscore);
            break;
        case "e":
            Console.WriteLine("Thanks");
            exit = false;
            break;
        default:
            Console.WriteLine("This command not found");
            break;
    }
}
