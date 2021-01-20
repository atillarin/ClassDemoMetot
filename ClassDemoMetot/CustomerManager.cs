using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoMetot
{
    class CustomerManager
    {
        public void Add(Customer cus)
        {
            Console.WriteLine(cus.Name +" kullanıcısı eklenmiştir.");
        }

        public void Delete(Customer cus)
        {
            Console.WriteLine(cus.Name+ " kullanıcısı silinmiştir");
        }

        public void List(Customer[] cus)
        {
            foreach (var x in cus)
            {
                Console.WriteLine("Müşteri Adı :"+ x.Name +" Soyadı : "+ x.Surname);
            }
        }
    }
}
