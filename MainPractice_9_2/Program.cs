var rd = new Random();
var son = rd.Next(1, 9);
do
{
    Console.WriteLine("enter any number");
    int son1;

    try
    {
        if (!int.TryParse(Console.ReadLine(), out son1))
        {
            throw new FormatException("Not a number");
        }

        if (son1 == son)
        {
            Console.WriteLine("Congrats! You guessed it");
            break;
        }
        throw new ArgumentOutOfRangeException("You couldn't guess it");

    }
    catch (ArgumentOutOfRangeException ect)
    {
        Console.WriteLine(ect.Message);
    }
    catch (FormatException ecst)
    {
        Console.WriteLine(ecst.Message);
    }


} while (true);
//int b;
//int i = 0;
//if (!int.TryParse(Console.ReadLine(), out b))
//{
//    throw new FormatException("test utdi");
//}
//if (i == b)
//{
//    throw new ArgumentOutOfRangeException ("teng");
//}
//else
//{
//    throw new FormatException("raqam teng emas");
//}
