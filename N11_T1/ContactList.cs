using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11_T1
{
    public class ContactList
    {
        private List<Contact> Contacts = new List<Contact>();

        public ContactList() 
        {
            Contacts.Add(new Contact("G'ishtmat", "Teshavoyev", "+998 99 123 45 67", "g`ishmat.dizayner@gmail.com"));
            Contacts.Add(new Contact("G'ishtmat", "G`ishtmatov", "+998 99 123 45 67 ", "g`ishmat.007@gmail.com"));
            Contacts.Add(new Contact("G'ishtmat", "G`ayratov", "+998 99 123 45 67", "g`ishmat.coder@gmail.com"));
            Contacts.Add(new Contact("Toshmat", "Toshmatov", "+998 99 123 46 67", "g`ishmat.marketolog@gmail.com"));
            Contacts.Add(new Contact("G'ani", "Qaniyev", "+998 99 123 97 77", "g`ishmat.mastaer@gmail.com"));

        }

        public void Display()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void Search(string firstname)
        {
            var check = true;
            foreach(var contact in Contacts)
            {
                if (contact.FirstName.ToLower().Contains(firstname.ToLower())
                    || contact.LastName.ToLower().Contains(firstname.ToLower()))
                    {
                        check = false;
                        Console.WriteLine(contact);
                    }
            }
            if(check) Console.WriteLine("Bunday foydalanuvchi topilmadi");
        }
    }
}
