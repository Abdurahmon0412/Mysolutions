namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TimeOnly startwork = new TimeOnly(8, 0);
            TimeOnly endwork = new TimeOnly(18, 0);

            DateTimeOffset[] metings = new DateTimeOffset[]
            {
                new DateTimeOffset(new DateTime(2023,12,12,15,25,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,19,5,45,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,13,15,55,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,7,7,50,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,22,15,20,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,5,11,12,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,2,15,15,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,4,18,35,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,23,15,39,00), TimeSpan.Zero),
                new DateTimeOffset(new DateTime(2023,12,7,2,52,00), TimeSpan.Zero),

            };

            TimeSpan[] metingsTime = new TimeSpan[]
            {
                TimeSpan.FromMinutes(30),
                TimeSpan.FromMinutes(52),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(15),
                TimeSpan.FromMinutes(12),
                TimeSpan.FromMinutes(50),
                TimeSpan.FromMinutes(65),
                TimeSpan.FromMinutes(35),
                TimeSpan.FromMinutes(22),
                TimeSpan.FromMinutes(12),
            };


            for (var meting = 0; meting < metingsTime.Length; meting++)
            {
                if (metings[meting].Hour < startwork.Hour || metings[meting].Hour > endwork.Hour ||
                    startwork.Hour + metingsTime[meting].TotalHours > endwork.Hour)
                {
                    Console.WriteLine(metings[meting]);
                }
            }
            Console.WriteLine("\n30 daqiqadan oshadigan meetinglar:\n");
            for (var meeting = 0; meeting < metingsTime.Length; meeting++)
            {
                if (metingsTime[meeting].TotalMinutes > 30)
                {
                    Console.WriteLine(metingsTime[meeting]);
                }
            }

            //var allMetings = TimeSpan.FromMinutes(0);
            var allMetings = 0;
            Console.WriteLine("barcha metinglar umumiy vaqti ");
            for (var meeting = 0; meeting < metingsTime.Length; meeting++)
            {
                allMetings += Convert.ToInt32(metingsTime[meeting].TotalMinutes);
            }
            Console.WriteLine(allMetings + " daqiqa");

            var temp = 0;
            for (int i = 0; i < metingsTime.Length - 1; i++)
            {
                if (Convert.ToInt32( metingsTime[i].TotalMinutes) > temp)
                {
                    temp = Convert.ToInt32( metingsTime[i].TotalMinutes);
                }
            }
            Console.WriteLine($"eng uzun meting {temp} daqiqa ");

            for (int i = 0; i < metingsTime.Length - 1; i++)
            {
                if (Convert.ToInt32(metingsTime[i].TotalMinutes) < temp)
                {
                    temp = Convert.ToInt32(metingsTime[i].TotalMinutes);
                }
            }
            Console.WriteLine($"eng qisqa meting {temp} daqiqa ");


        }
    }
}

//var  workStart = new TimeOnly(8, 0);
//var workEnd = new TimeOnly(18, 0);

//var meetingStartTime = new DateTimeOffset[10];

//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(-10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(-8), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(-9), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);
//meetingStartTime[0] = new DateTimeOffset(DateTime.Now.AddDays(10), TimeSpan.Zero);

/*string[] names = new string[]
{
    "Abdulla","Hoshim","Gani","Xusan","Xasan"
};
DateTime now = DateTime.Now;
DateTime[] Birthdays = new DateTime[5];
DateTime birthdays = new DateTime();

Birthdays[0] = new DateTime(2010, 2, 28);
Birthdays[1] = new DateTime(2015, 5, 15);
Birthdays[2] = new DateTime(2012, 7, 12);
Birthdays[3] = new DateTime(2017, 3, 31);
Birthdays[4] = new DateTime(2011, 12, 30);
string temp = "";
for (int i = 0; i < 5 - 1; i++)
{
    for(int j = i; j < 5; j++)
    {
        if(Convert.ToDateTime(Birthdays[i]).DayOfYear > Convert.ToDateTime(Birthdays[j]).DayOfYear)
        {
            temp = names[i];
            names[i] = names[j];
            names[j] = temp;
            birthdays = Birthdays[i];
            Birthdays[i] = Birthdays[j];
            Birthdays[j] = birthdays;
        }
    }
}
for (int i = 0;i < 5; i++)
{
    Console.WriteLine(Birthdays[i]);
    Console.WriteLine(names[i]);

}*/