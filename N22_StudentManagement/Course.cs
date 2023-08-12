using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_StudentManagement
{
    public class Course
    {
        public Guid CourceId { get; set; }
        public string Title { get; set; }

        public Course(string title)
        {
            Title = title;
            CourceId = Guid.NewGuid();
        }

    }
}
