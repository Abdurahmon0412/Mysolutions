using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_4
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content} - {Tag}\nLikes: {Likes}\tDislikes:{Dislikes}";
        }
    }
}
