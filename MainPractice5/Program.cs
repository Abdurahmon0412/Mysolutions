using System.Diagnostics;

Random rd = new Random();
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
String Application = "{ApplicationDate} \n{ApplicationNumber} \n{OrganizationName} rektori \n{Rektorga} ga\n Abituriyent: {StudentName}" +
    " dan \t\t\t\t\tTel.: {StudentNumber}\n\t\t\t\t\t\tARIZA\nMen joriy yilda ${OrganizationName} ning ${ Code} - ${ EduSpeciality} ta 'lim yo'nalishini" +
    " ${ EduForm}ta 'lim shakli, ${EduLanguage} ta'lim tili bo'yicha ${OrderId} - OTM sifatida tanlab, davlat test sinovida" +
    " ishtirok etdim.Davlat test markazi tomonidan e'lon qilingan test natijasiga ko'ra ${Ball} ball to'pladim" +
    " va to'lov-kontrakt asosidagi qabul chegarasiga ${DifferenceBall} ball yetmay qoldi .Shu munosabat bilan," +
    " meni qo'shimcha tarzda ${EduContractSumType} tabaqalashtirilgan to'lov-kontrakt asosida talabalikka qabul" +
    " qilishingizni hamda menga to`lov shartnomasini taqdim etishingizni so'rayman.Men Oliy ta'lim muassasasining" +
    " ichki tartib qoidalari va kontraktni barcha shartlari bilan tanishib chiqdim hamda tasdiqlangan o'quv rejasi" +
    " bo'yicha belgilangan vaqtlarda darslarga qatnashishga, belgilangan muddatlarda to'lov-kontrakt pulini to'lashga" +
    " va to'lov hujjatlarini topshirishga shaxsan o`zim mas'ulligimni tasdiqlayman.\nAbituriyent: ${Abiturient} \t\t\t" +
    "\t\tID raqami: ${AbiturientId}";

String appdata = DateTime.Now.ToString();
string appNumber = Guid.NewGuid().ToString();
string OrganizationName = "Najot Ta'lim";
string rektor = "Temurbek Adhamov";
string StudentName = "Abdurahmon Sadriddinov";
string StudentNumber = "+998938399777";
string id = Convert.ToString(rd.Next());
string Speciality = "Dotnet";
string Eduform = "Booutcamp";
string Edulanuage = "C#";
string orderID = Convert.ToString(rd.Next(1000,9999));
string ball = Convert.ToString(rd.Next(50, 100));
string differenceBall = Convert.ToString(rd.Next(10, 100));
string contract = Convert.ToString(rd.Next(1000000, 10000000));

Application = Application.Replace("${Abiturient}", StudentName);
Application = Application.Replace("${AbiturientId}", orderID);
Application = Application.Replace("{ApplicationDate}", appdata);
Application = Application.Replace("{ApplicationNumber}", appNumber);
Application = Application.Replace("{OrganizationName}", OrganizationName);
Application = Application.Replace("{Rektorga}", rektor);
Application = Application.Replace("{StudentName}", StudentName);
Application = Application.Replace("{StudentNumber}", StudentNumber);
Application = Application.Replace("${OrganizationName}", OrganizationName);
Application = Application.Replace("${ Code}", id);
Application = Application.Replace("${ EduSpeciality}", Speciality);
Application = Application.Replace("${ EduForm}", Eduform);
Application = Application.Replace("${EduLanguage}", Edulanuage);
Application = Application.Replace("${OrderId}", orderID);
Application = Application.Replace("${Ball}", ball);
Application = Application.Replace("${DifferenceBall}", differenceBall);
Application = Application.Replace("${EduContractSumType}", contract);


stopwatch.Stop();
TimeSpan ts = stopwatch.Elapsed;
Console.WriteLine(ts);


//Console.WriteLine(Application);
