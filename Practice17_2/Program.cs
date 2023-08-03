using Practice17_2;
using System.Security.Principal;

//EmailTemplateService service dan foydalaning

//unda quyidagi data member lar bo'lsin

//- Templates - email shablonlari kolleksiyasi

//unda quyidagi methodlar bo'lsin

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

var MessageConstant = new EmailTemplateService();
MessageConstant.Add(new Templates("Azizbek", "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi"));
MessageConstant.Add(new Templates("Mirzohid", "Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi"));
Console.WriteLine( MessageConstant.GetRegistrationTemplate("Azizbek"));
Console.WriteLine(MessageConstant.GetAccountBlockedTemplate("Mirzohid"));

