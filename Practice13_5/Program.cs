//Dictianary
using System.Text;
string parol = "Abdurahmon";

var DifferLanguages = new Dictionary<string, List<string>>();
DifferLanguages["en"] = new List<string>()
{
    "Enter Your Password: ",
    "Successfull Registration!",
    "Account Blocked."
};
DifferLanguages["uz"] = new List<string>()
{
    "Parolingizni kiriting: ",
    "Tizimga muvaffaqiyatli ro'yxatdan o'tdingiz!",
    "Akkount bloklangan."
};
DifferLanguages["ja"] = new List<string>()
{
    "パスワードを入力してください: ",
    "登録が成功しました！",
    "アカウントがブロックされました."
};
DifferLanguages["de"] = new List<string>()
{
    "Geben Sie Ihr Passwort ein: ",
    "Registrierung erfolgreich!",
    "Konto gesperrt."
};


Console.Write("Enter your Language:\n>>Uzbek - uz\n>>English - en\n>>Japan - ja\n>>German - de\n>> ");
var language = Console.ReadLine();
if (!DifferLanguages.ContainsKey(language))
{
    Console.WriteLine("Command not Found");
}
else
{
    Console.WriteLine(DifferLanguages[language][0]);
    if (parol == Console.ReadLine())
    {
        Console.WriteLine(DifferLanguages[language][1]);
    }
    else
    {
        Console.WriteLine(DifferLanguages[language][2]);
    }
}






