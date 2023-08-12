using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_StudentManagement
{
    public class University<TStudent,TId,TGrade> where TStudent:Student<TId,TGrade> 
    {
        public List<TStudent> Students;
        public List<Course> Cousrces;
        public University()
        {
            Students = new List<TStudent>();
            Cousrces = new List<Course>();
        }


        public void EnrollStudent(TStudent student, Course course)
        {
            Students.Add(student);
            Cousrces.Add(course);
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}



    }
}
