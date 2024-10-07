using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)


        {

            #region Yazdırma Komutları          

            //Console.WriteLine("******* Yemek Kategorileri *******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("******* Yemek Kategorileri *******");

            #endregion


            #region String Değişkenler

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Metin";
            //customerSurname = "Yazar";
            //customerPhone = "507 695 25 78";
            //customerEmail = "mtnyazar@gmail.com";
            //district = "Yıldırım";
            //city = "Bursa";

            //Console.WriteLine("**** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+ customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres: "+ district+"/"+city);
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine();

            //customerName = "Mehtap";
            //customerSurname = "Yazar";
            //customerPhone = "507 695 25 78";
            //customerEmail = "mhtpyazar@gmail.com";
            //district = "Yıldırım";
            //city = "Bursa";

            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------");


            #endregion


            #region Int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger Price: " + hamburgerPrice+" Tl");
            Console.WriteLine("------Coke Price: " + cokePrice+" Tl");
            Console.WriteLine("------Water Price: " + waterPrice+" Tl");
            Console.WriteLine("------Fries Price: " + friesPrice+" Tl");
            Console.WriteLine("------Pizza Price: " + pizzaPrice+" Tl");
            Console.WriteLine("------Lemonade Price: " + lemonadePrice+" Tl");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 2;
            int waterCount = 1;
            int friesCount = 0;
            int pizzaCount = 2;
            int lemonadeCount = 4;

            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalCokePrice= cokeCount * cokePrice;
            int totalWaterPrice= waterCount * waterPrice;
            int totalFriesPrice= friesCount * friesPrice;
            int totalPizzaPrice= pizzaCount * pizzaPrice;
            int totalLemonadePrice= lemonadeCount * lemonadePrice;

            
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + hamburgerPrice*hamburgerCount + " Tl");
            Console.WriteLine("Kola Tutarı : " + cokePrice*cokeCount + " Tl");
            Console.WriteLine("Su Tutarı : " + waterPrice*waterCount +" Tl");
            Console.WriteLine("Kızartma Tutarı : " + friesPrice*friesCount + " Tl");
            Console.WriteLine("Pizza Tutarı : " + pizzaPrice*pizzaCount + " Tl");
            Console.WriteLine("Limonata Tutarı : " + lemonadePrice*lemonadeCount + " Tl");
            Console.WriteLine("--------------------------------------------");

            int totalPrice=totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonadePrice;
            Console.WriteLine();
            Console.WriteLine("Ödenecek Toplam Tutar : "+ totalPrice+" TL");



            #endregion



            Console.Read();
            
        }
    }
}
