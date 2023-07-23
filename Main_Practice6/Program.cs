using Main_Practice6;
using System.Diagnostics;

List<Student> students = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 13, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 14, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 15, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 16, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 17, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};

int[,] balls = new int[,]
{
    { 90, 100, 75, 60 },
    { 100, 100, 70, 95 },
    { 90, 50, 60, 100 },
    { 60, 50, 100, 90 },
    { 100, 10, 75, 45 },
    { 55, 85, 70, 60 },
    { 95, 90, 40, 100 },
    { 80, 100, 100, 40 },
    { 65, 80, 100, 50 },
    { 80, 90, 100, 60 },
    { 90, 85, 65, 55 },
    { 100, 55, 90, 100 },
    { 80, 75, 90, 60 },
    { 90, 90, 100, 55 },
    { 100, 60, 90, 75 },
    { 90, 80, 50, 100 },
    { 100, 100, 60, 60 },
    { 90, 50, 80, 90 },
};

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
meny:
while (true)
{
    Console.WriteLine("1. Talabalar ruyhati");
    Console.WriteLine("2. Tulovlar");
    Console.WriteLine("3. Baholar");

    var choose = Console.ReadKey().KeyChar;
    Console.WriteLine();
    Thread.Sleep(100);
    Random rd = new Random();
    switch (choose)
    {
        case '1':
            Console.Clear();
            Console.Write("\n1. Dotnet talabalari\n2. Dizayn talabalari\n3. python talabalari\n4. smm talabalari");
            Console.WriteLine("\n\n5.Talaba qushish\n6.Talabani chopish");
            var yunalish = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (yunalish)
            {
                case '1':
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "DotNET")
                            Console.WriteLine($"{student.Id} - {student.FullName} - {student.GetAge()} - {student.Payment} - {student.EduType}");
                    }
                    break;
                case '2':
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "SMM")
                            Console.WriteLine($"{student.Id} - {student.FullName} - {student.GetAge()} - {student.Payment} - {student.EduType}");
                    }
                    break;
                case '3':
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "Python")
                            Console.WriteLine($"{student.Id} - {student.FullName} - {student.GetAge()} - {student.Payment} - {student.EduType}");
                    }
                    break;
                case '4':
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "Dizayn")
                            Console.WriteLine($"{student.Id} - {student.FullName} - {student.GetAge()} - {student.Payment} - {student.EduType}");
                    }
                    break;
                case '5':
                    Console.WriteLine("Enter student Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter student birthday[day/month/year]");
                    DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter student Edu Type");
                    string edutype = Console.ReadLine();
                    int id = students.Count + 1;
                    students.Add(new Student ()
                    {
                        Id = id,FullName = name,BirthDay = birthday,EduType = edutype,Payment = 0,PaymentAmount = 0
                    });
                    break;
                case '6':

                    Console.WriteLine("Enter student Id");
                    int sId = Convert.ToInt32( Console.ReadLine());
                    students.RemoveAt(sId - 1); 

                    break;
            }
            Console.WriteLine("0 ortga");
            if (Console.ReadKey().KeyChar == '0')
                goto meny;
            break;
        case '2':
            Console.Clear();
            Console.WriteLine("\n1. Dotnet talabalari\n2. Dizayn talabalari\n3. python talabalari\n4. smm talabalari");
            var pay = Console.ReadLine();
            switch (pay)
            {
                case "1":
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "DotNET")
                        {
                            if (student.Payment > student.PaymentAmount)
                            {

                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Qarzdor");
                            }
                            else if(student.Payment < student.PaymentAmount) 
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Qarzdor");

                            }
                            else 
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Hisobli dust ayrilmas");
                            }
                        }
                    }
                    break;
                case "2":
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "SMM")
                        {
                            if (student.Payment > student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Qarzdor");
                            }
                            else if (student.Payment < student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq:  {Math.Abs(student.Payment - student.PaymentAmount)}  Qarzdor");

                            }
                            else
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Hisobli dust ayrilmas");
                            }
                        }
                    }
                    break;
                case "3":
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "Python")
                        {
                            if (student.Payment > student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Qarzdor");
                            }
                            else if (student.Payment < student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq:  {Math.Abs(student.Payment - student.PaymentAmount)}  Qarzdor");

                            }
                            else
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Hisobli dust ayrilmas");
                            }
                        }
                    }
                    break;
                case "4":
                    Console.Clear();
                    foreach (Student student in students)
                    {
                        if (student.EduType == "Dizayn")
                        {
                            if (student.Payment > student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Qarzdor");
                            }
                            else if (student.Payment < student.PaymentAmount)
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq:  {Math.Abs(student.Payment - student.PaymentAmount)}  Qarzdor");

                            }
                            else
                            {
                                Console.WriteLine($"{student.Id} - {student.FullName.PadRight(45)} - {student.Payment} Tulagan {student.PaymentAmount} Qoldiq: {Math.Abs(student.Payment - student.PaymentAmount)} Hisobli dust ayrilmas");
                            }
                        }
                    }
                    break;
            }
            
            
            Console.WriteLine("hali qilinmadi:");
            break;
        case '3':
            Console.Clear();
            Console.Write("\t\tSANA\t\t\t\t  ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{rd.Next(10,30)}\t");
            }
            Console.WriteLine();
            for (int ball = 0; ball < students.Count; ball++)
            {

                while (students[ball].FullName.Length != 45)
                {
                    students[ball].FullName += ' ';
                }
                Console.Write($"{students[ball].Id.ToString().PadLeft(2, '0')} - {students[ball].FullName}");
                for (int ballB = 0; ballB < 4; ballB++)
                {
                    Console.Write($"{balls[ball, ballB]}\t");
                }
                Console.WriteLine();
            }
            break;

    }
}
stopwatch.Stop();
TimeSpan ts = stopwatch.Elapsed;
Console.WriteLine(ts);

