using System;
using System.Collections.Generic;
using System.Linq;
using Practice10_4;
public class BlogManager
{
    public void Analyze(List<BlogPost> blogPosts)
    {
        // Topiklarni va ularga mos contentlarni saqlash uchun dictionary
        Dictionary<string, List<string>> topicsWithContents = new Dictionary<string, List<string>>();

        // Har bir topik uchun like va dislike larni hisoblash uchun dictionary
        Dictionary<string, int> topicLikes = new Dictionary<string, int>();
        Dictionary<string, int> topicDislikes = new Dictionary<string, int>();

        // Bloglar ro'yxatida aylanish
        foreach (var post in blogPosts)
        {
            string[] tags = post.Tag.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Har bir mavzu uchun blog maqolani topicLikes va topicDislikes ga qo'shamiz
            foreach (string tag in tags)
            {
                if (!topicLikes.ContainsKey(tag))
                {
                    topicLikes[tag] = 0;
                    topicDislikes[tag] = 0;
                }

                topicLikes[tag] += post.Likes;
                topicDislikes[tag] += post.Dislikes;

                // Topiklarni va ularga mos contentlarni saqlash
                if (!topicsWithContents.ContainsKey(tag))
                {
                    topicsWithContents[tag] = new List<string>();
                }

                topicsWithContents[tag].Add(post.Content);
            }
        }

        // Takrorlanmas topiclarni hisoblash
        int totalUniqueTopics = topicLikes.Count;

        // Topiklarni yoqqanlik bo'yicha saralash
        var sortedTopics = topicLikes.OrderByDescending(x => x.Value - topicDislikes[x.Key]);

        // O'rtacha tekst uzunligi bo'yicha saralash
        var sortedTopicsByAverageLength = topicsWithContents.Select(topic => new
        {
            Topic = topic.Key,
            AverageContentLength = topic.Value.Average(content => content.Length)
        }).OrderByDescending(x => x.AverageContentLength);

        // Natijalarni ekran chiqarish
        Console.WriteLine("Takrorlanmas topiclar soni: " + totalUniqueTopics);
        Console.WriteLine("Topiklar yoqqanlik bo'yicha saralangan tartibda:");
        foreach (var topic in sortedTopics)
        {
            Console.WriteLine($"{topic.Key} - Yoqishlar: {topic.Value}, Yoqmasliklar: {topicDislikes[topic.Key]}");
        }

        Console.WriteLine("\nTopiklar o'rtacha kontent uzunligi bo'yicha saralangan tartibda:");
        foreach (var topic in sortedTopicsByAverageLength)
        {
            Console.WriteLine($"{topic.Topic} - O'rtacha uzunlik: {topic.AverageContentLength}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Bloglar ro'yxati
        List<BlogPost> blogPosts = new List<BlogPost>
        {
            new BlogPost { Id = Guid.NewGuid(), Title = "C# Blog Post", Content = "This is a C# blog post.", Tag = "csharp", Likes = 10, Dislikes = 2 },
            new BlogPost { Id = Guid.NewGuid(), Title = "JavaScript Blog Post", Content = "This is a JavaScript blog post.", Tag = "js", Likes = 8, Dislikes = 1 },
            new BlogPost { Id = Guid.NewGuid(), Title = "AI Blog Post", Content = "This is an AI blog post.", Tag = "ai", Likes = 15, Dislikes = 3 },
            new BlogPost { Id = Guid.NewGuid(), Title = "Another C# Blog Post", Content = "This is another C# blog post.", Tag = "csharp", Likes = 12, Dislikes = 2 },
            new BlogPost { Id = Guid.NewGuid(), Title = "Python Blog Post", Content = "This is a Python blog post.", Tag = "python", Likes = 7, Dislikes = 1 }
        };

        BlogManager blogManager = new BlogManager();
        blogManager.Analyze(blogPosts);
    }
}
