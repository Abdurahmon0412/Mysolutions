string Application = "string application = \"{ApplicationDate} {ApplicationNumber} {OrganizationName} derektori {Rektor} ga Abituriyent ${StudentName}" +
    " danTel.: ${ StudentNumber}ARIZAMen joriy yilda ${OrganizationName}ning ${ Code}- ${ EduSpeciality}ta 'lim yo'nalishini ${ EduForm}ta 'lim shakli," +
    " ${EduLanguage} ta'lim tili bo'yicha ${OrderId} - OTM sifatida tanlab, davlat test sinovida ishtirok etdim.Davlat test markazi tomonidan e'lon qilingan" +
    " test natijasiga ko'ra ${Ball} ball to'pladim va to'lov-kontrakt asosidagi qabul chegarasiga ${DifferenceBall} ball yetmay qoldi .Shu munosabat bilan," +
    " meni qo'shimcha tarzda ${EduContractSumType} tabaqalashtirilgan to'lov-kontrakt asosida talabalikka qabul qilishingizni hamda menga to`lov" +
    " shartnomasini taqdim etishingizni so'rayman.Men Oliy ta'lim muassasasining ichki tartib qoidalari va kontraktni barcha shartlari bilan tanishib" +
    " chiqdim hamda tasdiqlangan o'quv rejasi bo'yicha belgilangan vaqtlarda darslarga qatnashishga, belgilangan muddatlarda to'lov-kontrakt pulini " +
    "to'lashga va to'lov hujjatlarini topshirishga shaxsan o`zim mas'ulligimni tasdiqlayman.Abituriyent: ${ Abiturient}ID raqami: ${ AbiturientId}\"";



Application = Application.Replace("{ApplicationDate} ", DateTime.Now.ToString());
Application = Application.Replace("{ApplicationNumber}", Guid.NewGuid().ToString());
string OrganizationName = "Najot Ta'lim ";
Application = Application.Replace("{OrganizationName}", OrganizationName);
string StudentName = "Abdurahmon";
string rektor = "Temurbek Adhamov";
Application = Application.Replace("{Rektor}", rektor);
//Application = Application.Replace()
//Application = Application.Replace
//Application = Application.Replace
//Application = Application.Replace
//Application = Application.Replace
//Application = Application.Replace
Console.WriteLine(Application);

//Console.WriteLine("Enter OrganizationName");
//Console.WriteLine("Enter StudentName");
//string StudentName = Console.ReadLine();
//Console.WriteLine("Enter StudentNumber");
//int SutdentNumber = Convert.ToInt32( Console.ReadLine());
//Console.WriteLine("Enter OrganizationName");
//s
//string OrganizationName = Console.ReadLine();
//Console.WriteLine("Enter OrganizationName");
//string OrganizationName = Console.ReadLine();
//Console.WriteLine("Enter OrganizationName");




