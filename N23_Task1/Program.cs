List<int> Numbers = new List<int>();
Numbers.Add(322);
Numbers.Add(-1);
Numbers.Add(11);
Numbers.Add(3);
Numbers.Add(9);
Numbers.Add(10);

var allPozitive = Numbers.All(number => number >= 0);
Console.WriteLine($"hammasi musbatmi - {allPozitive}");

var anyOdd = Numbers.Any(number => number % 2 == 1);
Console.WriteLine($"ichida toq sonlar bormi - {anyOdd}");

var contain = Numbers.Contains(3) && Numbers.Contains(9);
Console.WriteLine($"ichida 3 && 9 sonlari bormi - {contain}");