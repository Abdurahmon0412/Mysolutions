using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10_4
{
    public class BlogManager
    {

        public void Analyze(List<BlogPost> blogPosts) 
        {

            foreach (var post in blogPosts)
            {
                var postTopics = post.Tag.Split(',');
                var uniqueTopics = new List<string>();
                foreach (var topic in postTopics)
                {
                    if (!uniqueTopics.Contains(topic.Trim()))
                    {
                        uniqueTopics.Add(topic.Trim());
                    }
                }

                var topicContents = new Dictionary<string, List<string>>();
                foreach (var topic in postTopics)
                {
                    if (!topicContents.ContainsKey(topic.Trim()))
                    {
                        topicContents[topic.Trim()] = new List<string>();
                    }
                    topicContents[topic.Trim()].Add(post.Content);
                }
                Console.WriteLine("heelo");
                foreach (var topic in uniqueTopics)
                {
                    var likes = 0;
                    var dislikes = 0;

                    foreach (var posts in blogPosts)
                    {
                        if (post.Tag.Contains(topic.Trim()))
                        {
                            likes += post.Likes;
                            dislikes += post.Dislikes;
                        }
                    }

                    var rating = likes - dislikes;


                }
            }
            int middleLenght = 0;
            for (var postA = 0; postA < blogPosts.Count;postA++)
            {
                middleLenght += blogPosts[postA].Content.Length;
                for(var postB = 0;postB < blogPosts.Count; postB++)
                {
                    if((blogPosts[postB].Likes - blogPosts[postB].Dislikes) < (blogPosts[postA].Likes - blogPosts[postA].Dislikes))
                    {
                        var temp = blogPosts[postA];
                        blogPosts[postA] = blogPosts[postB];
                        blogPosts[postB] = temp;

                    }
                }

            }
            for(var postB = 0;postB<blogPosts.Count;postB++)
            {
                Console.WriteLine(blogPosts[postB] +  "\tUrtacha content uzunligi\n");
            }
                Console.WriteLine($"urtacha kontent uzunligi: {middleLenght / blogPosts.Count}");

        }
    }
}
