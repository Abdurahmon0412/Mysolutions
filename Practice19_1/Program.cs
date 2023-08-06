using Practice19_1;

var kons1 = new Person();

var kons2 = new Person(kons1);
var kons4 =  Person2.GetInstance();
var kons3 = new Person("abdurahmon", 20, "Kattaqurgon", "uzbek");

Console.WriteLine(kons3);
Console.WriteLine(kons1);
Console.WriteLine(kons2);

