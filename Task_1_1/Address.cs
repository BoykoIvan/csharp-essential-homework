using System;
namespace Task_1_1
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get =>index;
            set => index = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Street
        {
            get => street;
            set => street = value;
        }

        public string House
        {
            get => house;
            set => house = value;
        }

        public string Apartment
        {
            get => apartment;
            set => apartment = value;
        }
    }
}
