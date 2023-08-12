using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N23_Task2
{
    public class Book
    {
        //Book modelidan foydalaning ( name, rating, author ) -rating 1 dan 10 gacha 
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }

        public Book(string name, int rating, string author)
        {
            Name = name;
            Rating = rating;
            Author = author;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Rating: {Rating} Author: {Author}";
        }
    }
}
