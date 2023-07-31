//emperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
//- unda Temperature write-only parameteri bo'lsin
//- har safar set qilganda temperature list ga saqlab borilsin
//- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin
using Practice16_2;

var a = new TempperatureSensorServise();
a.Display();
a.Tempreture = "birinchi fix";
a.Tempreture = "Ikkinchi fix";
a.Tempreture = "uchinchi fix";
a.Tempreture = "turtinchi fix";
a.Tempreture = "beshinchi fix";

a.Display();