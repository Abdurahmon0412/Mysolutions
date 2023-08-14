using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23_Filter_model
{
    public class EmployeeService
    {
        private List<Employee> _employees;


        public EmployeeService(params Employee[] employees)
        {
            _employees = new List<Employee>()
        {
            new ("John", "Smith", 60000, 85),
            new ("Emily", "Johnson", 55000, 78),
            new ("Michael", "Williams", 70000, 92),
            new ("Sarah", "Davis", 45000, 65),
            new ("Robert", "Brown", 65000, 75),
            new ("Jessica", "Wilson", 50000, 80),
            new ("David", "Martinez", 75000, 88),
            new ("Jennifer", "Anderson", 58000, 72),
            new ("James", "Taylor", 53000, 95),
            new ("Amanda", "Thomas", 48000, 68)
        };


        }
        public List<Employee> GetBySalary(int pageSize, int pageToken)
        {
            //var totalPages = _employees.Count / pageSize;
            var respsonse = _employees.Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();

            return respsonse;
        }


    }
}
