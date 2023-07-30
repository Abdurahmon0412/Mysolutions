using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice11_2
{
    public class MovieLibrary
    {
        public List<Movie> Movies = new List<Movie>();
        public MovieLibrary() 
        {
            Movies.Add(new Movie("Inception", "Science, Fiction,Action",5.5));
            Movies.Add(new Movie(" The Shawshank Redemption", "Drama, Herror", 7.5));
            Movies.Add(new Movie("The Dark Knight", "Action, Crime, Drama", 6.8));
            Movies.Add(new Movie("Interstellar", "Science, Fiction,Adventure", 9.5));
            Movies.Add(new Movie("Pulp Fiction", " Crime, Drama", 4.5));
            Movies.Add(new Movie("The Godfather", "Crime, Drama", 5));
            Movies.Add(new Movie("Forrest Gump", "Drama, Romance", 8.5));
            Movies.Add(new Movie("The Matrix", "Science, Fiction,Action", 9.5));
            Movies.Add(new Movie("Schindler's List", "Biography, Drama, History", 5.9));
            Movies.Add(new Movie("Kurtlar vadisi", "Aksiyon, Drama, Politika", 10));


        }

        public void Display()
        {
            foreach (var movie in Movies)
            {
                Console.WriteLine(movie);
            }
        }

        public void SearchByName(string name)
        {
            foreach (var movie in Movies)
            {
                if (movie.FilmName.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine(movie);
                }
            }

        }

        public void SearchByGenre(string genre)
        {
            foreach(var movie in Movies)
            {
                if (movie.FilmGenre.ToLower().Contains(genre.ToLower()))
                {
                    Console.WriteLine(movie);
                }
            }
        }

        public void SearchByScoreHigherThan(double score)
        {
            foreach (var movie in Movies)
            {
                if (movie.FilmReview > score)
                {
                    Console.WriteLine(movie);
                }
            }
        }

}
}
