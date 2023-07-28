//string[] filmNames = new string[]
//{
//    "Inception",
//    "Dark Knight",
//    "Top Gun 2",
//    "Don't Look Up",
//    "Top Gun"
//};

//for(int i = 0; i < filmNames.Length - 1; i++)
//{
//    for(int j = i; j < filmNames.Length; j++)
//    {
//        if (filmNames[i].CompareTo(filmNames[j]) == 1)
//        {
//            var temp = filmNames[i];
//            filmNames[i] = filmNames[j];
//            filmNames[j] = temp;
//        }
//    }
//}

//foreach(string name in filmNames)
//{
//    Console.WriteLine(name);
//}
//Console.WriteLine("endi kamayish");
////if (movies[i].CompareTo(movies[j]) == 1)
//for (int i = 0; i < filmNames.Length - 1; i++)
//{
//    for (int j = i; j < filmNames.Length; j++)
//    {
//        if (filmNames[i].CompareTo(filmNames[j]) == -1)
//        {
//            var temp = filmNames[i];
//            filmNames[i] = filmNames[j];
//            filmNames[j] = temp;
//        }
//    }
//}

//foreach (string name in filmNames)
//{
//    Console.WriteLine(name);
//}


//Dictionary<int , int > age = new Dictionary<int, int> ();
//var ages = new int[] 
//{
//12,
//15,
//25,
//12,
//56,
//13,
//81,
//55,
//25,
//12
//};

//foreach(var i in ages)
//{
//    if (age.ContainsKey(i))
//    {
//        age[i]++;
//    }
//    else
//    {
//        age[i]= 1;
//    }
//}
//foreach (var i in age)
//{
//    if(i.Value > 1)
//    Console.WriteLine($"{i.Key} - {i.Value}");
//}


//string[] Contacts = new string[]
//{
//    "Peter Michael Brown",
//    "John David Smith",
//    "John Johns Jones",
//    "G`ishtmat G`ishtmatov G`ishtmatovich"
//};

//Console.WriteLine("keywordni kiriting");
//var key = Console.ReadLine();
//foreach (var contact in Contacts)
//{
//    if (contact.ToLower().Contains(key.ToLower()))
//    {
//        Console.WriteLine(contact);
//    }
//}

string[] xoctagon1 = new string[]
{
    "John", "Tom", "Tim",
};
string[] xoctagon2 = new string[]
{
    "John", "Tom", "Tims",
};
for (int i = 0; i < xoctagon1.Length - 1; i++)
{

    for (int j = i; j < xoctagon1.Length; j++)
    {
        if (xoctagon1[i].CompareTo(xoctagon1[j]) == -1)
        {
            var temp = xoctagon1[i];
            xoctagon1[i] = xoctagon1[j];
            xoctagon1[j] = temp;
        }
    }
}
for (int i = 0; i < xoctagon2.Length - 1; i++)
{

    for (int j = i; j < xoctagon2.Length; j++)
    {
        if (xoctagon2[i].CompareTo(xoctagon2[j]) == -1)
        {
            var temp = xoctagon2[i];
            xoctagon2[i] = xoctagon2[j];
            xoctagon2[j] = temp;
        }
    }
}
bool istrue = false;
for (int i = 0; i < xoctagon2.Length; i++)
{
    if (xoctagon1[i] != xoctagon2[i])
    {
        Console.WriteLine("False");
        istrue = true;
        break;
    }
}
if (!istrue)
{
    Console.WriteLine("True");
}
