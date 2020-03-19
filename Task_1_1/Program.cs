using System;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address { Index = "394000", City = "Voronezh", Country = "Russia", Street = "Platonova", House = "19", Apartment = "14" };

            Console.WriteLine("My address:");
            Console.WriteLine(new string('-', 15));

            Console.WriteLine("Index: {0}", address.Index);
            Console.WriteLine("Country: {0}", address.Country);
            Console.WriteLine("City: {0}", address.City);
            Console.WriteLine("Street: {0}", address.Street); 
            Console.WriteLine("House: {0}", address.House);
            Console.WriteLine("Apartment: {0}", address.Apartment);
        }
    }
}
