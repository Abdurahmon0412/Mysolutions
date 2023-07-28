using Practice12_2;
List<User> Users = new List<User>();

User a1 = new User(  "Anvar","Anvarov","Anvarovich");
User a2 = new User("qobil", "qobilov", "qobilovich");
User a3 = new User("fozil", "fozilov", "fozilovich");
User a4 = new User("mac", "macov", "macovich");
Users.Add( a1);
Users.Add(a2);
Users.Add(a3);
Users.Add(a4);
while (true)
{
    Console.WriteLine("Ism familya va ichistvangizni kiriting[ism fam,ichs] kurinishida");
    var name = Console.ReadLine();
    var first = Console.ReadLine();
    var last = Console.ReadLine();
    var objectnew = new User(name,first,last);
    bool isqueue = true;
    foreach (User user in Users)
    {
        if(user.Equals(objectnew))
        {
            Console.WriteLine("Siz uzi navbatdasiz");
            isqueue = false;
        }
       
    }
    if (isqueue)
    {
        Users.Add(objectnew);
        Console.WriteLine("siz navbatga qushildiz");
        foreach (User user in Users)
        {
            Console.WriteLine($"{user.Name} {user.FirstName} {user.LastName}");
        }
    }
}


