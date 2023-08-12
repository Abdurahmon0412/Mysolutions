using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Dedline { get; set; }
        public Developer Assignee { get; set; }
        public bool IsCompleted { get; set; }

        public List<string> Comments;

        public Task(string title, string description, DateTime dedline)
        {
            Comments = new List<string>();
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Dedline = dedline;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
