using Project1;
using System.Threading.Channels;

List<Team> teams = new List<Team>()
        {
            new Team() { Id = 1, ClubName = "Barselona", City = "Ispaniya" },
            new Team() { Id = 2, ClubName = "Real Madrid", City = "Ispaniya" },
            new Team() { Id = 3, ClubName = "Manchester City", City = "Angliya" },
            new Team() { Id = 4, ClubName = "Bavariya", City = "Germaniya" },
            new Team() { Id = 5, ClubName = "Nasaf", City = "Uzbekistan" },
            new Team() { Id = 6, ClubName = "Zenit", City = "Rossiya" },
        };

List<Player> players = new List<Player>()
        {
            new Player() { Id = 1, Name = "Messi", TeamId = 1, Level = 94},
            new Player() { Id = 2, Name = "Ronaldu", TeamId = 2, Level = 92},
            new Player() { Id = 3, Name = "Lewandowski", TeamId = 4, Level = 89},
            new Player() { Id = 4, Name = "De Bryune", TeamId = 3, Level = 88},
            new Player() { Id = 5, Name = "Neymar", TeamId = 1, Level = 90},
            new Player() { Id = 6, Name = "Suarez", TeamId = 1, Level = 88},
            new Player() { Id = 7, Name = "Haaland", TeamId = 3, Level = 86},
            new Player() { Id = 8, Name = "Myuller", TeamId = 4, Level = 84},
            new Player() { Id = 9, Name = "Bale", TeamId = 2, Level = 82},
            new Player() { Id = 10, Name = "Ismoilov", TeamId = 5, Level = 70},
            new Player() { Id = 11, Name = "Shomurodov", TeamId = 2, Level = 78},
            new Player() { Id = 12, Name = "Cherishev", TeamId = 2, Level = 78},
            new Player() { Id = 13, Name = "Vafoyev", TeamId = 2, Level = 78},
            new Player() { Id = 14, Name = "Denisov", TeamId = 2, Level = 78},
            new Player() { Id = 15, Name = "Latipov", TeamId = 2, Level = 78},
            new Player() { Id = 16, Name = "Jesus", TeamId = 2, Level = 78},
            new Player() { Id = 17, Name = "Genynrikh", TeamId = 2, Level = 78},
            new Player() { Id = 18, Name = "Jesus", TeamId = 2, Level = 78},
            new Player() { Id = 19, Name = "Debala", TeamId = 2, Level = 78},
            new Player() { Id = 20, Name = "HarriKane", TeamId = 2, Level = 78},
            new Player() { Id = 21, Name = "Salah", TeamId = 2, Level = 78},
            new Player() { Id = 22, Name = "Benzema", TeamId = 2, Level = 78},
        };

//Select
//var result = players.Select(a => new { Name = a.Name, Lavel = a.Level });
//players.Select(a => new { a.Name, a.Level }).ToList().ForEach(Console.WriteLine);
//Find
//var messi = players.Find(a => a.Name == "Messi");
//messi.Level = 82;

//Where

//players.Where(a => a.Name == "Modric").ToList().ForEach(a => Console.WriteLine(a.Name + "\t" + a.Level));


//OrderBy: 

//players.OrderBy(a => a.Level ).Select(a => new { a.Name, a.Level}).ToList().ForEach(Console.WriteLine);

//OrderByDescending: 
//players.OrderByDescending(a => a.Id).Select(a => new { a.Name, a.Level })
//.ToList().ForEach(a => Console.WriteLine(a.Name + "\n" + a.Level));
//ThenBy: 
//players.Select(a => new { a.Id, a.Name, a.Level })
//    .OrderByDescending(a => a.Level)
//    .ThenByDescending(a => a.Name).ToList()
//    .ForEach(a => Console.WriteLine($"Name: {a.Name} - Level: {a.Level}"));
//ThenByDescending: 
//players.Select(a => new { a.Id, a.Name, a.Level })
//    .OrderByDescending(a => a.Level)
//    .ThenByDescending(a => a.Name).ToList()
//    .ForEach(a => Console.WriteLine($"Name: {a.Name} - Level: {a.Level}"));

//Join: 
var result = players.Join(teams,
                        player => player.TeamId,
                        team => team.Id,
                        (player, team) => new
                        {
                            ClubName = team.ClubName,
                            Name = player.Name,
                            Level = player.Level
                        });
result.ToList().ForEach(player => Console.WriteLine($"Club: {player.ClubName.PadRight(15)}" +
    $"Name: {player.Name.PadRight(15)} {player.Level}"));
//Aggregate: 

//GroupBy: 

//ToLookup:

//GroupJoin: 

//Reverse:

//All:

//Any: 

//Contains: 

//Distinct: 

//Except: 

//Union: 

//Intersect: 

//Count: 

//Sum:

//Average: 

//Min:

//Max:

//Take:

//Skip: 

//TakeWhile: 

//SkipWhile: 

//Concat: 

//Zip: 

//First: 

//FirstOrDefault: 

//Single: 

//SingleOrDefault: 

//ElementAt: 

//ElementAtOrDefault: 

//Last: 

//LastOrDefault: