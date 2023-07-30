using Practice10_3;

var check = new Validator();
Console.Write(" Enter Name: ");
Console.WriteLine(check.IsValidAge(Console.ReadLine()));
Console.Write("Email address: ");
Console.WriteLine(check.IsValidEmailAddress(Console.ReadLine()));
Console.Write("Phone number: ");
Console.WriteLine(check.IsValidPhoneNumber(Console.ReadLine()));
