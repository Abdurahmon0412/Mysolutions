using Practice10_1;

Console.WriteLine("Enter firstname: ");
string firstname;
string lastname;
do
{
    firstname = Console.ReadLine();

} while (!(string.IsNullOrWhiteSpace(firstname)));
Console.WriteLine("Enter lastname: ");
do
{
    lastname = Console.ReadLine();

} while (!(string.IsNullOrWhiteSpace(lastname)));
Console.WriteLine("Enter Age: ");
int userage = 0;
var exit = true;
do
{

    try
    {
        userage = int.Parse(Console.ReadLine());
        exit = false;
    }
    catch
    {
        Console.WriteLine("Iltimos faqat son kiriting");
    }

}while (exit);
User user = new User(firstname,lastname,userage);
Console.WriteLine(user.GetUser());

