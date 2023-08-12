
//using System;
//int a = 5, b = 6;
//int S, P;
//GetArea(a, b, out S, out P);
//Console.WriteLine($"S = {S} {P}");




//void GetArea(int a, int b, out int S, out int P)
//{
//    P = 2 * (a + b);
//    S = a * b;
//}
//var numbers = Console.ReadLine().Split();
//FindMinMax(numbers);


//void FindMinMax(params string[] numberss)
//{
//    int[] numbers = new int[numberss.Length];
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = Convert.ToInt32(numberss[i]);
//    }
//    var MaxNumber = 0;
//    for(int max = 0; max < numbers.Length; max++)
//    {
//        if (numbers[max] > MaxNumber) {  MaxNumber = numbers[max]; }
//    }
//    var minNumber = numbers[0];
//    for(int min  = 0; min < numbers.Length;min++ )
//    {
//        if(minNumber > numbers[min])
//        {
//            minNumber = numbers[min];
//        }
//    }
//    Console.WriteLine(minNumber + "  " + MaxNumber);
//}


Person person = new Person("Abdurahmon", 20, true);

person.Display(name: "Abdurahmon", ismarried: true, age: 20);



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }

    public Person(string name,int age, bool ismarried)
    {
        Name = name;
        Age = age;
        IsMarried = ismarried;
    }

    public void Display(string name = "", int age = 0,bool ismarried = false)
    {
        Console.WriteLine($"Name: {name} \nAge:{age}\nIsmarried{ismarried}");
    }
}