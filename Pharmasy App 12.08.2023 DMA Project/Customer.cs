using System;

namespace Pharmasy_App_12._08._2023_DMA_Project
{
    public class Customer
    {
        private Guid _id;
        public Guid Id { get
            {
                return _id;
            } 
            set
            {
                _id = value;
            }
        }
        public string Name;
        public string Surname;
        public int Age;
        public Medicine[] medicines;

        public Customer()
        {

        }

        public Customer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

}
