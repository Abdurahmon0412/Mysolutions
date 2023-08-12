using N23_Task2;
using static System.Reflection.Metadata.BlobBuilder;

//Book modelidan foydalaning ( name, rating, author ) -rating 1 dan 10 gacha 
//- undan list yaratib bir nechta kitoblar qo'shing
//- kitoblarni rating kamayishi tartibida bo'yicha saralang
//- biror author bo'yicha birinchi va oxirgi kitobni ekranga chiqaring 
// ( bunda o'sha muallifni enga yaxshi va eng yomon baholangan kitobi chiqadi )


List<Book> Books = new List<Book>();

Books.Add(new Book("Utgan kunlar", 10, "Taga'ay Murod"));
Books.Add(new Book("1984", 8, "Xudoyberdi Tuxtaboyev"));
Books.Add(new Book("Tafsiri Hilol", 10, "Muhammad Sodiq"));
Books.Add(new Book("Sariq devni Ulimi", 9, "Xudoyberdi Tuxtaboyev"));
Books.Add(new Book("Qasoskorning oltin boshi", 5, "Xudoyberdi Tuxtaboyev"));

Books.OrderByDescending(book => book.Rating).ToList().ForEach(book => Console.WriteLine(book));

var byAuthorfirst = Books.OrderByDescending(book => book.Rating).FirstOrDefault(book => book.Author == "Xudoyberdi Tuxtaboyev");
var byAuthorlast = Books.OrderByDescending(book => book.Rating).LastOrDefault(book => book.Author == "Xudoyberdi Tuxtaboyev");
Console.WriteLine(byAuthorfirst);
Console.WriteLine(byAuthorlast);
