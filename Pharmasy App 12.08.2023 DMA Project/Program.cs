using System;
using System.Collections.Generic;

namespace Pharmasy_App_12._08._2023_DMA_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Static
            //List<Medicine> medicines = new List<Medicine>();


            //Pharmacy pharmacy1 = new Pharmacy();
            //pharmacy1.Name = "Seymur";
            //pharmacy1.City = "Sumqayit";
            //pharmacy1.Street = "Semed Vurgun";
            //pharmacy1.Region = "1ci Mkr";

            //Console.WriteLine(pharmacy1.Name); 


            //Medicine medicine1 = new Medicine();

            //medicine1.Name = "Analgin";
            //medicine1.Type = "Agrikesici";
            //medicine1.Count = 100;
            //medicine1.pharmacyId = pharmacy1.Id;

            //Console.WriteLine(medicine1.Name);
            #endregion

            #region Dynamic

            Pharmacy newPharmacy = null;
            Medicine newMedicine = null;
            List<Medicine> medicines = null;
            List<Medicine> oldMed = null;

            #region Show Menu
            //Console.WriteLine("1 Create Pharmacy \n" +
            //                  "2 Create Medicine \n" +
            //                  "3 Add Medicine \n" +
            //                  "4 Show Medicines \n" +
            //                  "5 Sell Medicine");

            //bool T = int.TryParse(Console.ReadLine(), out int num);
            //if (T)
            //{
            //    switch (num)
            //    {
            //        case 1:
            //        m1: Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin adini yazin");
            //            string pharmacyName = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin hansi seherde olacagini yazin");
            //            string city = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin hansi kucede oldugunu yazin");
            //            string street = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin adressini yazin");
            //            string region = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin postal codu-nu yazin");
            //            string postalCode = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin elaqe nomresini yazin");
            //            int phoneNumber = int.Parse(Console.ReadLine());

            //            Pharmacy pharmacy = new Pharmacy(pharmacyName, city, street, region, postalCode, phoneNumber);
            //            newPharmacy = pharmacy;

            //            break;
            //        case 2:
            //            Console.WriteLine("Zehmet olmasa daxil olunan dermanin adini yazin");
            //            string medicineName = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa daxil olunan dermanin tipini yazin");
            //            string medicineType = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa daxil olunan dermanin sayini yazin");
            //            int medicineCount = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Zehmet olmasa daxil olunan dermanin qiymetini yazin");
            //            decimal medicinePrice = decimal.Parse(Console.ReadLine());

            //            Medicine medicine = new Medicine(medicineName, medicineType, medicineCount, medicinePrice, pharmacy.Id);
            //            newMedicine = medicine;
            //            break;
            //        case 3:
            //            if (oldMed == null)
            //            {
            //                medicines = new List<Medicine>();
            //            }
            //            else
            //            {
            //                medicines = oldMed;
            //            }


            //            medicines.Add(newMedicine);
            //            oldMed = medicines;
            //            break;
            //        case 4:
            //        l1: Pharmacy.ShowMedicines(pharmacy, medicines);

            //            //Console.WriteLine("Derman elave etmek ucun 1\n" +
            //            //                  "Siyahiya baxmaq ucun 2\n" +
            //            //                  "Satis ucun 3 duymesine click edin");
            //            //int value = int.Parse(Console.ReadLine());
            //            //switch (value)
            //            //{
            //            //    case 1: goto m1;
            //            //    case 2: goto l1;
            //            //    case 3: goto c1;
            //            //    default:
            //            //        Console.WriteLine("Click again!");
            //            //        break;
            //            //}
            //            break;
            //        case 5:
            //        c1: Console.WriteLine("Zehmet olmasa adinizi teqdim edin");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa soyadinizi teqdim edin");
            //            string surname = Console.ReadLine();
            //            Console.WriteLine("Zehmet olmasa yasinizi qeyd edin");
            //            int age = int.Parse(Console.ReadLine());

            //            Customer customer = new Customer(name, surname, age);

            //            Console.WriteLine("Zehmet olmasa alacagini dermanin sayini bildirin");
            //            int count = int.Parse(Console.ReadLine());

            //            Pharmacy.SellMedicine(newPharmacy, customer, medicines, newMedicine, count);
            //            break;
            //        default:
            //            break;
            //    }

            //}
            #endregion

            #region Create Pharmacy
            //Create Pharmacy
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin adini yazin");
            string pharmacyName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin hansi seherde olacagini yazin");
            string city = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin hansi kucede oldugunu yazin");
            string street = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin adressini yazin");
            string region = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin postal codu-nu yazin");
            string postalCode = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa acmaq istediyiniz Aptekin elaqe nomresini yazin");
            int phoneNumber = int.Parse(Console.ReadLine());

            Pharmacy pharmacy = new Pharmacy(pharmacyName, city, street, region, postalCode, phoneNumber);

        #endregion

        #region Create Med
        //Create Medicine

        m1: Console.WriteLine("Zehmet olmasa daxil olunan dermanin adini yazin");
            string medicineName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa daxil olunan dermanin tipini yazin");
            string medicineType = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa daxil olunan dermanin sayini yazin");
            int medicineCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa daxil olunan dermanin qiymetini yazin");
            decimal medicinePrice = decimal.Parse(Console.ReadLine());


            Medicine medicine = new Medicine(medicineName, medicineType, medicineCount, medicinePrice, pharmacy.Id);
            newMedicine = medicine;
            //Add Medicine for Pharmacy
            if (oldMed == null)
            {
                medicines = new List<Medicine>();
            }
            else
            {
                medicines = oldMed;
            }

            Pharmacy.AddMedicines(newPharmacy, medicines, newMedicine);

            oldMed = medicines;
            #endregion


        #region ShowMed
        l1: Pharmacy.ShowMedicines(pharmacy, oldMed);

        s1: Console.WriteLine("Derman elave etmek ucun 1 \n" +
                              "Siyahiya baxmaq ucun 2 \n" +
                              "Satis ucun 3 \n" +
                              "Axtaris etmek ucun 4 \n" );
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1: goto m1;
                case 2: goto l1;
                case 3: goto c1;
                case 4: goto f1;
                default:
                    Console.WriteLine("Click again!");
                    break;
            }

        #endregion

        #region Sale

        //SaleMed

        c1: Console.WriteLine("Zehmet olmasa adinizi teqdim edin");
            string name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadinizi teqdim edin");
            string surname = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa yasinizi qeyd edin");
            int age = int.Parse(Console.ReadLine());

            Customer customer = new Customer(name, surname, age);

            Pharmacy.ShowMedicines(pharmacy, oldMed);
            Console.WriteLine("Zehmet olmasa alacaginiz dermanin adini bildirin");
            string saleMedName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa alacaginiz dermanin sayini bildirin");
            int count = int.Parse(Console.ReadLine());

            Pharmacy.SellMedicine(pharmacy, customer, medicines, saleMedName, count);

        #endregion

        #region Search Filter
        //Filter Search
        f1: Console.WriteLine("          Zehmet olmasa axtaris ucun secim edin.");
            Console.WriteLine("       Dermanin novuve gore axtaris etmek ucun 1\n" +
                              "       Qiymetine gore axtaris etmek ucun 2 duymesine click edin " +
                              "       Derman uzerinde deyisiklik etmek ucun 3 duymesine click edin \n" +
                              "\n");

            bool numT = int.TryParse(Console.ReadLine(), out int num);
            if (numT)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("     Zehmet olmasa axtardiginiz dermanin tipini yazin");
                        string pharType = Console.ReadLine();
                        Pharmacy.FilterByType(pharmacy, pharType, medicines);
                        break;
                    case 2:
                        Console.WriteLine("     Zehmet olmasa qiymete gore axtaris edin");
                        bool pT = decimal.TryParse(Console.ReadLine(), out decimal pharPrice);
                        if (pT)
                        {
                            Pharmacy.FilterByPrice(pharmacy, pharPrice, medicines);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Zehmet olmasa deyismek istediyiniz dermanin adini yazin.");
                        string uName = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa dermanin yeni adini qeyd edin.");
                        string pNewName = Console.ReadLine();
                        Pharmacy.UpdateMedicine(pharmacy, uName, pNewName, medicines);
                        break;
                    default:
                        Console.WriteLine("Click again!");
                        break;
                }
            }
            else
            {
                goto f1;
            }
            #endregion

            Console.WriteLine("Thanks \n");
            goto s1;





            #endregion
        }


    }
}
