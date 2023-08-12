using Project_Linq;

var regisservis = new RegistrationServicedan();

regisservis.Register("aizbek@gmail.com", "123456789");
regisservis.Register("Firdavs@gmail.com", "789654321");
regisservis.Register("abdurahmon@gmail.com", "00000000");
regisservis.Login("aizbek@gmail.com", "123456789");
regisservis.Register(Console.ReadLine(),Console.ReadLine());