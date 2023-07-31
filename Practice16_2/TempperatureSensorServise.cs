using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//emperaturani saqlab boradigan TemperatureSensorService servisidan foydalaning
//- unda Temperature write-only parameteri bo'lsin
//- har safar set qilganda temperature list ga saqlab borilsin
//- saqlang temperaturalar Display methodi orqali ekranga chiqarilsin

namespace Practice16_2
{
    public class TempperatureSensorServise
    {
        private string _tempreture;
        private List<string> TempList = new List<string>();
        public string Tempreture
        {

            set 
            {
               _tempreture = value; 
                TempList.Add(value);
            } 
        }
        public void Display()
        {
              if(TempList.Count > 0)
              {

                  Console.WriteLine("bu listni ichi");
                  foreach (var temp in TempList)
                  {
                      Console.WriteLine(temp);
                  }
              }
              else { Console.WriteLine("this list is empty"); }
        }
    }
}
