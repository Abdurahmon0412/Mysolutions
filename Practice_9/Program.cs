using System.Diagnostics;
using System.Net;

namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
        }
    }
}
//    using System.Diagnostics;

//    Stopwatch stopWatch = new Stopwatch();
//    stopWatch.Start();

//int[] numbers = { 200, 100, 250, 200, 250, 100, 100, 200, 250 };


//    var messages = string.Empty;
//for (var i = 0; i<numbers.Length; i++)
//{
//    var count = 0;
//    for (var j = 0; j<numbers.Length; j++)
//    {
//        if (numbers[j] == numbers[i])
//        {
//            count++;
//        }
//    }
//    var sum = 0;
//for (var d = 0; d < count - (count / 3); d++)
//{
//    sum += Convert.ToInt32(numbers[i]);
//}
//if ((count / 3) > 0)
//{
//    var req = $"{numbers[i]} - {count} , {count / 3} ta chegirma, Narx: {sum}\n";
//    if (!messages.Contains(req))
//    {
//        messages += req;
//    }
//}
//else
//{
//    var req2 = $"{numbers[i]} - {count} ta chegirma yo'q, Narx: {sum}";
//    if (!messages.Contains(req2))
//    {
//        messages += req2;
//    }
//}
//}
//stopWatch.Stop();
//TimeSpan ts = stopWatch.Elapsed;
//Console.WriteLine(ts);





