using System;
using System.Collections.Generic;
using System.Linq;

namespace Pharmasy_App_12._08._2023_DMA_Project
{
    class Pharmacy
    {
        public Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name;
        public string City;
        public string Street;
        public string Region;
        private string _postalCode;
        private int _phoneNumber;
        public List<Medicine> medicines;


        public Pharmacy()
        {
        }

        public Pharmacy(string name, string city, string street, string region, string postalCode, int phoneNumber)
        {

            Guid guid = Guid.NewGuid();
            _id = guid;
            Name = name;
            City = city;
            Street = street;
            Region = region;
            _postalCode = postalCode;
            _phoneNumber = phoneNumber;

            Console.WriteLine("Yeni Aptek Yaradildi.");
            Console.WriteLine($"         Id:    {_id}\n" +
                              $"       Name:    {FirstCharUp(Name)}\n" +
                              $"       City:    {FirstCharUp(City)}\n" +
                              $"     Street:    {FirstCharUp(Street)}\n" +
                              $"     Region:    {FirstCharUp(Region)}\n" +
                              $" PostalCode:    {_postalCode}\n" +
                              $"PhoneNumber:    {_phoneNumber}\n");
        }



        public static void AddMedicines(Pharmacy pharmacy, List<Medicine> medicines, Medicine medicine)
        {
            decimal gap = 0;
            if (medicines.Count == 0 || medicine == null)
            {
                medicines.Add(medicine);
            }
            else if (medicine.Count > 0)
            {
                for (int i = 0; i <= medicines.Count - 1; i++)
                {
                    if (medicine.Name.ToLower() == medicines[i].Name.ToLower())
                    {
                        gap = medicine.buyPrice - medicines[i].buyPrice;
                        medicines[i].Count += medicine.Count;
                        medicines[i].Type = medicine.Type;
                        medicine.pharmacyId = medicines[i].pharmacyId;
                        Console.WriteLine($"Depoya elave {medicine.Count} eded {FirstCharUp(medicine.Name)} dermani elave olundu");
                        if (medicine.buyPrice > medicines[i].buyPrice)
                        {
                            Console.WriteLine($"{FirstCharUp(medicine.Name)} dermanin qiymeti {gap} manat yukseldi");
                        }
                        else if (medicine.buyPrice < medicines[i].buyPrice)
                        {
                            Console.WriteLine($"{FirstCharUp(medicine.Name)} dermanin qiymeti {-1 * gap} manat endirildi");
                        }
                        else
                        {
                            Console.WriteLine($"{FirstCharUp(medicine.Name)} dermanin qiymetinde hec bir deyisiklik yoxdur");
                        }
                        medicines[i].buyPrice = medicine.buyPrice;
                        return;
                    }
                }
                medicines.Add(medicine);
            }
        }

        public static void UpdateMedicine(Pharmacy pharmacy, string name, string newName, List<Medicine> medicines)
        {
            if(name != null)
            {
                foreach (Medicine med in medicines)
                {
                    if (med.Name.ToLower().Split()==name.ToLower().Split())
                    {
                        med.Name = newName;
                        Console.WriteLine($"         Dermanin adi:   {FirstCharUp(newName)} \n" +
                                     $"             Dermanin tipi:   {FirstCharUp(med.Type)} \n" +
                                     $"             Dermanin Sayi:   {med.Count} \n" +
                                     $"     Dermanin alis Qiymeti:   {med.buyPrice} \n" +
                                     $"    Dermanin satis Qiymeti:   {med.salePrice} \n \n");

                    }
                }
            }
        }

        public static void SellMedicine(Pharmacy pharmacy, Customer customer, List<Medicine> medicines, string medName, int count)
        {
            foreach (var medicine in medicines)
            {

                if (medName.ToLower().Contains(medicine.Name.ToLower()))
                {
                    medicine.salePrice = medicine.buyPrice + 10 * medicine.buyPrice / 100;
                    decimal price = medicine.salePrice * count;
                    medicine.Count = medicine.Count - count;
                    medicine.customerId = customer.Id;
                    Console.WriteLine($" {count} eded {FirstCharUp(medicine.Name)} , {FirstCharUp(customer.Name)} terefinden {price} manata alindi. ");
                    ShowMedicines(pharmacy, medicines);
                    return;
                }
            }
            Console.WriteLine("Teessuf ki, istediyiniz derman hal hazirda depoda qalmayib");
        }

        public static void ShowMedicines(Pharmacy pharmacy, List<Medicine> medicines)
        {
            Console.WriteLine($"{pharmacy.Name} aptekdeki dermanlarin siyahisi: \n");

            foreach (Medicine medicine in medicines)
            {
                if (pharmacy.Id == medicine.pharmacyId)
                {
                    Console.WriteLine($"              Dermanin adi:   {FirstCharUp(medicine.Name)} \n" +
                                      $"             Dermanin tipi:   {FirstCharUp(medicine.Type)} \n" +
                                      $"             Dermanin Sayi:   {medicine.Count} \n" +
                                      $"     Dermanin alis Qiymeti:   {medicine.buyPrice} \n" +
                                      $"    Dermanin satis Qiymeti:   {medicine.salePrice} \n \n");
                }
                else
                {
                    Console.WriteLine("else");
                }
            }
        }

        public static void FilterByType(Pharmacy pharmacy, string type, List<Medicine> medicines)
        {
            int c = 0;
            foreach (var medicine in medicines)
            {
                medicine.salePrice = medicine.buyPrice + 10 * medicine.buyPrice / 100; ;
                if (type != null)
                {
                    if (medicine.Type.ToLower().Contains(type.ToLower()))
                    {
                        c++;
                        Console.WriteLine($"    Name: {FirstCharUp(medicine.Name)} \n" +
                                          $"    Type: {FirstCharUp(medicine.Type)} \n" +
                                          $"    Count: {medicine.Count} \n" +
                                          $"    Price: {medicine.salePrice}  \n");
                    }
                }
            }
            if (c == 0)
            {
                Console.WriteLine($"Teessuf ki, bizde {type} dermani yoxdur");
            }
        }
        public static void FilterByPrice(Pharmacy pharmacy, decimal price, List<Medicine> medicines)
        {
            int c = 0;
            foreach (var medicine in medicines)
            {
                if (medicine.buyPrice == price)
                {
                    c++;
                    Console.WriteLine($"    Name: {FirstCharUp(medicine.Name)} \n" +
                                      $"    Type: {FirstCharUp(medicine.Type)} \n" +
                                      $"    Count: {medicine.Count} \n" +
                                      $"    Price: {medicine.salePrice}  \n");
                }
            }
            if (c == 0)
            {
                Console.WriteLine($"Teessuf ki, bizde {price} manat deyerinde derman yoxdur");
            }
        }

        static string FirstCharUp(string word)
        {
          string w = word.ToLower().Trim();
          
            string newWord = "";
            char FirstCharUp = ' ';

            for (int i = 0; i < w.Length; i++)
            {

                if (i == 0)
                {
                    FirstCharUp = w[i];
                    FirstCharUp = char.ToUpper(FirstCharUp);
                    newWord += FirstCharUp;

                }
                else
                {
                    if (word[i] == ' ')
                    {
                        FirstCharUp = w[i + 1];
                        FirstCharUp = char.ToUpper(FirstCharUp);
                        newWord += " ";
                        newWord += FirstCharUp;
                        i++;
                    }
                    else
                    {
                        newWord += w[i];
                    }
                }
            }
            return newWord;
        }

        //public static void CharToUpper(string word1, string word2)
        //{
        //    word1.ToLower();
        //    word2.ToLower();
        //    string newWord = "";
        //    char FirstCharUp = 'a';
        //    char secondChar = 'b';
        //    for (int i = 0; i < word1.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            FirstCharUp = word1[i];
        //            FirstCharUp = char.ToUpper(FirstCharUp);
        //            newWord += FirstCharUp;
        //        }
        //        else
        //        {
        //            newWord += word1[i];
        //        }
        //    }
        //    newWord += " ";
        //    for (int i = 0; i < word2.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            secondChar = word2[i];
        //            secondChar = char.ToUpper(secondChar);
        //            newWord += secondChar;
        //        }
        //        else
        //        {
        //            newWord += word2[i];
        //        }
        //    }
        //    Console.WriteLine(newWord);
        //}

    }
}
