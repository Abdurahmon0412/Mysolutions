using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Main_Practice6
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDay { get; set; }

        public int Payment { get; set; }

        public string EduType { get; set; }

        public decimal PaymentAmount { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDay.Year;
        }
    }
    
}
