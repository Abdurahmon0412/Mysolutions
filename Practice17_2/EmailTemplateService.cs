using Practice17_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//- Add ( subject, content ) -email shablonini validate qilib, kolleksiyaga qo'shsin
//- GetRegistrationTemplate ( string username ) -shablonlar orasidan ro'yxatdan o'tganlik shablonini olib, message ga aylantirib jo'natsin
//- GetAccountBlockedTemplate ( string username ) -shablonlar orasidan akkount bloklanganlik shablonini olib, message ga aylantirib jo'natsin

//MessageConstants - static modelda quyidagi tokenlar konstanta holatida saqlansin

//- UserToken - {{UserToken}}
//-EmailTemplateService dan object yarating, 2 ta template qo'shing
//- ro'yxatdan o'tganlik va akkount bloklanganlik shablonlarini kerakli methodlar orqali olib, ekranga chiqaring


//Example

//Subject : Account Registration
//Content : Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi

//Subject : Account Blocked
//Content :  Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi
namespace Practice17_2
{
    public class EmailTemplateService
    {

        public List<Templates> templates = new List<Templates>();

        public void Add(Templates template)
        {
            if(!string.IsNullOrWhiteSpace(template.Subject))
            {
                templates.Add(template);
            }
            else
            {
                throw new Exception("Email shablon is empty");
            }
        }
        public string GetRegistrationTemplate(string username)
        {
            foreach(Templates template in templates)
            {
                if(template.Subject.Contains(username,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return template.Content.Replace(MessageConstants.UserToken,username);
                }
            }
            return "username not found";
        }

        public string GetAccountBlockedTemplate(string username)
        {
            foreach (Templates template in templates)
            {
                if (template.Subject.Contains(username,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return template.Content.Replace(MessageConstants.UserToken, username);
                }
            }
            return "username not found";
        }
    }
}
