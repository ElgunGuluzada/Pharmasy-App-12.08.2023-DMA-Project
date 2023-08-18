using System;
using System.Collections.Generic;

namespace Pharmasy_App_12._08._2023_DMA_Project
{
    public class Medicine
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name;
        public string Type;
        public int Count;
        public decimal buyPrice;
        public decimal salePrice;
        public Guid _pharmacyId;
        public Guid pharmacyId
        {
            get { return _pharmacyId; }
            set { _pharmacyId = value; }
        }
        public Guid customerId;


        public Medicine()
        {

        }

        public Medicine(string name, string type, int count, decimal price, Guid pharmacyId)
        {
            Guid guid = Guid.NewGuid();
            _id = guid;
            Name = name;
            Type = type;
            Count = count;
            buyPrice = price;
            salePrice = price+price*10/100;
            _pharmacyId = pharmacyId;

            Console.WriteLine("Yeni Derman Daxil edildi.");
            Console.WriteLine($"        Id:   {_id}\n" +
                              $"      Name:   {Name}\n" +
                              $"      Type:   {Type}\n" +
                              $"     Count:   {Count}\n" +
                              $"     Price:   {buyPrice}\n" +
                              $"PharmacyId:   {_pharmacyId}\n");
        }

     
    }
}
