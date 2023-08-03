using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//- email jo'natish uchun EmailService dan foydalaning 
//- unda CredentialAddress va CredentialPassword init only propertylar bo'lsin
//- methodlardan SendEmail( to ) methodi bo'lsin
//- foydalanuvchidan email addresini so'rang
//- kiritilgan email addressga "Siz muvaffaqiyatli registratsiyadan o'tdingiz" nomli email borsin

namespace Practice16_1
{
    public class EmailService
    {
            public string CredentialAddress  { get; init;}
            public string CredentialPassword { get; init; }
            public string Name { get; init; }
        public EmailService(string credintialemail, string credintialpassword) 
        {
            CredentialAddress = credintialemail;
            CredentialPassword = credintialpassword;
        }

        public void SendEmail(string receiverEmail,string name)
        {
            
            var CredentialAddress = "abdurahmonsadriddinov0412@gmail.com";
            var CredentialPassword = "bypucbhumkeghlab";

            var mail = new MailMessage(CredentialAddress, receiverEmail);
            mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
            mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz Tabriklaymiz".Replace("{{User}}", name);
            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
            smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }

}
