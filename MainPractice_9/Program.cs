namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter your yong ");
            try
            {
                int yosh = Convert.ToInt32(Console.ReadLine());
            string Massage = yosh switch
            {
                > 90 => throw new ArgumentOutOfRangeException("Sorry you're too old "),
                < 18 => throw new ArgumentOutOfRangeException("Sorry you're too young "),
                _ => "Valid age"
            };
            if(Massage == "Valid age")
                    {
                        Console.WriteLine(Massage);
                    }               
            }
            catch(ArgumentOutOfRangeException ect)
            {
                Console.WriteLine(ect.Message);
            }

        }
    }
}


