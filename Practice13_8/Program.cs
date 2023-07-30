//Stack
using System;
using System.Collections.Generic;

class Program
{
    static Stack<string> browserHistory = new Stack<string>();

    static void Main()
    {
        Console.WriteLine("Dastur boshlandi.");
        var b = "";
        while (true)
        {
            Console.WriteLine("Hozirgi URL ni kiriting:");
            string currentURL = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(currentURL))
            {
                Console.WriteLine("URL bo'sh bo'lishi mumkin emas. Dastur tugatildi.");
                break;
            }
            Console.WriteLine("Buyruqni tanlang ('back' - b, 'forward' - f):");
            string command = Console.ReadLine().ToLower();
            switch (command)
            {
                case "b":
                    if (browserHistory.Count > 1)
                    {
                        var a = browserHistory.Pop();
                        Console.WriteLine(a);
                        Console.WriteLine("hamma urllar");
                        Display();
                    }
                    else
                    {
                        Console.WriteLine("You're currently in this site.");
                    }
                    break;
                case "f":
                    if(b == currentURL.ToLower())
                    {
                        Console.WriteLine("You're currently in this site.");
                        break;
                    }
                    b = currentURL.ToLower();
                    browserHistory.Push(currentURL);

                    Console.WriteLine($"{currentURL} +++ Forward qilindi.");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri buyruq kiritdingiz!");
                    break;
            }

        }
        
    }
    public static void Display()
    {
        foreach (var browserHistorys in browserHistory)
        {
            Console.Write(browserHistorys);
        }
    }
}
