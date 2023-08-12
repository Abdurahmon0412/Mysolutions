// concat - 2 ta to'plamni birlashtirish
// intersect - 2 ta to'plamning bir xil elementlarini olish
// except - 2 ta to'plamning farqi
// union - 2 ta to'plamning birlashmasi - faqat unique elementlarni olish

// var listA = new List<int>
// {
//     1,
//     2,
//     3
// };
// var listB = new List<int>
// {
//     2,
//     4,
//     5
// };
// listA.Except(listB).ToList().ForEach(Console.WriteLine);

// Eski usul
// var aggregator = new CollectionAggregator();

// Yangi usul
using N22_Aggregation;

var aggregator = null as ICollectionAggregation;
aggregator = new CollectionAggregator();

var listA = new List<int>
{
    1,
    2,
    3
};

var listB = new List<int>
{
    2,
    4,
    5
};

// aggregator = new NewCollectionAggregator();

Console.WriteLine("Concat result : ");
aggregator.Concat(listA, listB).ForEach(Console.WriteLine);

Console.WriteLine();
Console.WriteLine("Intersect result : ");
aggregator.Intersect(listA, listB).ForEach(Console.WriteLine);

Console.WriteLine("Except result : ");
aggregator.Except(listA, listB).ForEach(Console.WriteLine);


Console.WriteLine("Union result : ");
aggregator.Union(listA, listB).ForEach(Console.WriteLine);