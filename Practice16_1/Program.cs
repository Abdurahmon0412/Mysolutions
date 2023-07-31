//Registratsiyadan keyin email jo'natadigan dastur tuzing

//- email jo'natish uchun EmailService dan foydalaning 
//- unda CredentialAddress va CredentialPassword init only propertylar bo'lsin
//- methodlardan SendEmail( to ) methodi bo'lsin
//- foydalanuvchidan email addresini so'rang
//- kiritilgan email addressga "Siz muvaffaqiyatli registratsiyadan o'tdingiz" nomli email borsin

//Example 

//subject - Siz muvaffaqiyatli registratsiyadan o'tdingiz
//body - "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz"



using System.Net.Mail;
using System.Net;
using Practice16_1;

Console.WriteLine("ismiz");
var name = Console.ReadLine();
Console.WriteLine("email");
var email = Console.ReadLine();
Console.WriteLine("enter passaword");
var pass = Console.ReadLine();
var Email = new EmailService(email, pass);
Email.SendEmail(email, name);