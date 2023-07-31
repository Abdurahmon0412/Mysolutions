using System;
using System.Collections.Generic;
using System.Linq;
using Practice10_4;

namespace Practice10_4 { 
    class Program
    {
        static void Main(string[] args)
        {
            // Bloglar ro'yxati
            List<BlogPost> blogPosts = new List<BlogPost>
                {
                    new BlogPost { Id = Guid.NewGuid(), Title = "C# Blog Post", Content = "This is a C# blog post.", Tag = "csharp,js,c", Likes = 10, Dislikes = 2 },
                    new BlogPost { Id = Guid.NewGuid(), Title = "JavaScript Blog Post", Content = "This is a JavaScript blog post.", Tag = "js,python", Likes = 8, Dislikes = 1 },
                    new BlogPost { Id = Guid.NewGuid(), Title = "AI Blog Post", Content = "This is an AI blog post.", Tag = "ai,math", Likes = 15, Dislikes = 3 },
                    new BlogPost { Id = Guid.NewGuid(), Title = "Another C# Blog Post", Content = "This is another C# blog post.", Tag = "csharp,Java", Likes = 12, Dislikes = 2 },
                    new BlogPost { Id = Guid.NewGuid(), Title = "Python Blog Post", Content = "This is a Python blog post.", Tag = "python,C++", Likes = 7, Dislikes = 1 }
                };
            var blogmenager = new BlogManager();
            blogmenager.Analyze(blogPosts);
        }   
    }
}
