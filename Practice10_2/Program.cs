using Practice10_2;

namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("parolda raqamlar bulsinmi[y/n]");
            bool hasdigit = true ? Console.ReadLine().ToLower() == "y": false;
            
            Console.WriteLine("parolda harflar bulsinmi[y/n]");
            bool hasletter = true ? Console.ReadLine().ToLower() == "y" : false;

            Console.WriteLine("parolda simbollar bulsinmi[y/n]");
            bool hassymbol = true ? Console.ReadLine().ToLower() == "y" : false;

            Console.WriteLine("Enter a password length");
            var length = Convert.ToInt32(Console.ReadLine());


            var Passgenerat = new PasswordGenerator();
            var password = Passgenerat.Generate(hasdigit,hasletter,hassymbol,length);

            Console.WriteLine("Your password is created: " + password);
        }
    }
}