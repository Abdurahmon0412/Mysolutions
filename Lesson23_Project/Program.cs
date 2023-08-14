using Lesson23_Project;
using System.Text.Json;
using Newtonsoft.Json;
public class Program
{
    public static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person{Id = 1,Name = "Begzod", Age = 15},
            new Person{Id = 2,Name = "Bunyod", Age = 20}
        };

        var path = @"D:\Projects\Files\Person";

        string jsonPerson = JsonConvert.SerializeObject(people,Formatting.Indented);


        using (StreamWriter writer = new StreamWriter(path,false))
        {
            writer.Write(jsonPerson + "\n");
            writer.Close();
        }

        using (StreamReader reader = new StreamReader(path))
        {
            var text = JsonConvert.DeserializeObject<List<Person>>(reader.ReadToEnd());
            reader.Close();
            people.ForEach(person => Console.WriteLine($"{person.Name}"));
        }
    }
}