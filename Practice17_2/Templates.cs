using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice17_2
{
    public class Templates
    {
        public string Subject {  get; set; }
        public string Content { get; set; }
        public Templates(string subject, string content) 
        {
            Subject = subject;
            Content = content;
        }
    }
}
