using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_StudentManagement
{
    public class Student<TId, TGrade>
    {
        public TId StudentID { get; set; }
        public string Name { get; set; }
        public TGrade Grade { get; set; }


        public Student(TId id, string name,TGrade grade)
        {
            StudentID = id;
            Name = name;
            Grade = grade;
        }


        public override string ToString()
        {
            return $"{StudentID} | {Name} | {Grade}";
        }

    }
}
