using Project23_Filter_model;

var EmplaoyeeServices = new EmployeeService();
var result = EmplaoyeeServices.GetBySalary(1,5);
foreach(var res in result)
{
    Console.WriteLine(res);
}

