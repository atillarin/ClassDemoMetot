using System;

namespace ClassDemoMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer() { Id =0,Name="Atilla",Surname="Çökmez" };
            Customer cus2 = new Customer() { Id = 1, Name = "Rümeysa", Surname = "Doğan" };
            Customer cus3 = new Customer() { Id = 2, Name = "Nehir", Surname = "Tuna" };
            Customer[] customers = new Customer[] { cus1,cus2,cus3};

            CustomerManager cusman = new CustomerManager();

            cusman.Add(cus1);
            cusman.Add(cus2);
            cusman.List(customers);


        }
    }
}
