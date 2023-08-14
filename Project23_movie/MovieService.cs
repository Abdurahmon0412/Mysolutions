using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23_movie
{
    public class MovieService
    {
        private List<Movie> _movieList;
        public MovieService() 
        {
            _movieList = new List<Movie>();
        }
        public List<Movie> Search(string searchKeyword)
        {
            return _movieList
                .Where(movie => 
                    movie.Name.Contains(searchKeyword,StringComparison.OrdinalIgnoreCase) 
                    || movie.Author.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();
        }

        public void Add(Movie movie)
        {
            _movieList.Add(movie);
        }

        public List<Movie> GetByRating()
        {
            return _movieList.OrderBy(movie => movie.Rating).ToList();
        }


    }
}
