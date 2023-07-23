namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stp = Convert.ToString(Console.ReadLine());
            var s2 = stp.Split(" ");
            int j = 0;
            foreach (string s in s2)
            {
                j++;
                for (int i = 0; i < s.Length; i++)
                {
                    if (j <= 3)
                    {


                        if (i == 0)
                        {
                            Console.Write(s[i].ToString().ToUpper());
                        }
                        if (j > 2)
                        {

                        }
                        Console.Write(s[i].ToString().ToLower());
                    }
                    else
                    {
                        Console.Write(s[i].ToString().ToLower());
                    }
                }
                Console.Write(" ");
           


            }

                
        
        }
    }
}