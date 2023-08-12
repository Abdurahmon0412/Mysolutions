using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks;

        public Project(string title, string description)
        {
            Tasks = new List<Task>();
            Description = description;
            Title = title;
            Id = Guid.NewGuid();

        }

        public void AddTask(Task task) { }
    }
}
