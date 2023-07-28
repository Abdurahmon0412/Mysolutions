
using N14_3;

var check = new Validator();
Console.Write(" Enter Name: ");
Console.WriteLine(check.IsValidName(Console.ReadLine()));
Console.Write("Email address: ");
Console.WriteLine(check.IsValidEmail(Console.ReadLine()));
Console.Write("Phone number: ");
Console.WriteLine(check.IsValidPhoneNumber(Console.ReadLine()));