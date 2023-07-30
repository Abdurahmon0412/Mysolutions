using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_2
{
    public class Movie
    {
        
        public string FilmName { get; set; }
        public string FilmGenre { get; set; }
        public double FilmReview { get; set; }
        public Movie(string filmname, string filmgenre,double filmreview) 
        {
            FilmName = filmname;
            FilmGenre = filmgenre;
            FilmReview = filmreview;
        }

        public override string ToString()
        {
            return $"Movie name - {FilmName}, Genre - {FilmGenre}, Review Score - {FilmReview}";
        }

    }
}
