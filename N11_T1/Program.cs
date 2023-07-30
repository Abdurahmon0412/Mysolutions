using N11_T1;

var Person = new ContactList();
var exit = true;
while (exit)
{
    //Thread.Sleep(5000);
    //Console.Clear();
    Console.WriteLine("Choose a command ( display all - d / search- f exit - e)");
    var choose = Console.ReadLine();
    switch (choose.ToLower())
    {
        case "d":
            Person.Display();
            break;
        case "f":
            Console.WriteLine("Enter a firstname: ");
            var search = Console.ReadLine();
            Person.Search(search);
            break;
        case "e":
            Console.WriteLine("Thanks");
            exit = false;
            break;
        default:
            Console.WriteLine("Bunday comanda yuq: ");
            break;
    }
}
