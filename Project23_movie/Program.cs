using Project23_movie;

var MovieServices = new MovieService();

MovieServices.Add(new Movie("Eternal Echoes", "Samantha Carter", 8));
MovieServices.Add(new Movie("Whispers in the Wind", "Benjamin Turner", 7));
MovieServices.Add(new Movie("Midnight Serenade", "Emily Mitchell", 9));
MovieServices.Add(new Movie("Forgotten Realms", "Alexander Roberts", 6));
MovieServices.Add(new Movie("Shadows of Yesterday", "Michael Hughes", 7));
MovieServices.Add(new Movie("Eternal Echoes", "Samantha Carter", 8));
MovieServices.Add(new Movie("Dreams of Tomorrow", "Sophia Walker", 9));
MovieServices.Add(new Movie("Echoes of Destiny", "Daniel Adams", 8));
MovieServices.Add(new Movie("Whispers of Hope", "Lily Johnson", 7));
MovieServices.Add(new Movie("Rays of Eternity", "Christopher Baker", 6));


var forRaiting = MovieServices.GetByRating();
foreach (var item in forRaiting)
{
    Console.WriteLine(item);
}

var forSearch = MovieServices.Search("e");
//foreach (var item in forSearch)
//{
//    Console.WriteLine(item);
//}