using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23_Filter_model
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Salary { get; set; }
        public int KPI { get; set; }


        public Employee(string firstname, string lastname, int salary, int kpi) 
        {
            Firstname = firstname;
            Lastname = lastname;
            Salary = salary;
            KPI = kpi;
        }

        public override string ToString()
        {
            return $"{Firstname} - {Lastname} - {Salary} - {KPI}";
        }
    }
}
