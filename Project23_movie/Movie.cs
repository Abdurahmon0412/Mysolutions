using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23_movie
{
    public class Movie
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }

        public Movie(string name, string author, int raiting )
        {
            Name = name;
            Author = author;
            Rating = raiting;
        }

        public override string ToString()
        {
            return $"{Name} - {Author} - {Rating}";
        }
    }
}
