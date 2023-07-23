string[] Names = new string[]
   {
        "Abdulxayev Jasurbek Anvar O'g'li",
        "Abdumannonov Botirjon Davlat O'g'li",
        "Abdurahmonov Azizbek Alisher O'g'li",
        "Anvarjonov Ozodbek Avazxon O'g'li",
        "Asadov Firdavs Asqarbek O'g'li",
        "Eshmurodov Umarali Abduhalim O'g'li",
        "Ibrohimjonov Shodiyor Ziyodali O'g'li",
        "Jo'raboyev Boburjon Murodjon O'g'li",
        "Kamolov Bunyod Maruf O'g'li",
        "Karimjonov Ilhom Ramzjon O'g'li",
        "Komiljonov Muhammadaziz Abduraximovich",
        "Rashidov Asadbek",
        "Sadriddinov Abdurahmon Jurabek O'g'li",
        "Sattorova Habiba Shuxrat Qizi",
        "Tolibov Firdavs Odil O'g'li",
        "To'rayev Dinur Alisher O'g'li",
        "Vositov Muhammadrizo Muhammadtolib O'g'li",
        "Xaybullayev Mexroj Mansurjonovich",
        "Xolmuratov Qurbonali Suxrob O'g'li"
   };

Console.WriteLine("Search: ");
Console.WriteLine(Names.Length);
string search = Console.ReadLine();
search.ToUpper();
foreach (var name in Names)
{
    if (name.Contains(search, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine(name);
    }
}