using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();
sw.Stop();

var Prices = new Dictionary<int, int>();



//var inputPrices = Console.ReadLine().Split();
string[] inputPrices = new string[] { "200", " 100", "250", "200", "250", "100", "100", "200", "250" };
foreach (var input in inputPrices)
{
    var Count = 0;

    if (Prices.ContainsKey(Convert.ToInt32(input)))
    {
        Prices[Convert.ToInt32(input)]++;
    }
    else
    {
        Prices.Add(Convert.ToInt32(input), 1);
    }
}


foreach (var item in Prices)
{
    Console.WriteLine($"{item.Key} = {(item.Value - (item.Value / 3)) * item.Key}");
    Console.WriteLine(item.Value + "    " + item.Key);
}
sw.Stop();
TimeSpan ts = sw.Elapsed;
Console.WriteLine(ts);
