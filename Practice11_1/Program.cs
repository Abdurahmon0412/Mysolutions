using Practice11_1;
namespace Mysolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Matn = "Lorem ipsum dolor sit amet" +
                " consectetur adipisicing elit.quaerat" +
                " est quas commodi quibusdam labore, nihil" +
                " doloribus quam temporibus inventore optio" +
                " expedita consectetur voluptatem QUIDEM nulla" +
                " soluta earum. Numquam rem alias minima culpa" +
                " iste distinctio. Eum similique est consequuntur" +
                " minus, odio nisi recusandae iure asperiores facere," +
                " reiciendis voluptate maiores! Repellat, dolorum!";

            var doc = new Document(Matn);
            Console.WriteLine( new DocumentAnalyzer().Analiz(doc));

        }
    }
}