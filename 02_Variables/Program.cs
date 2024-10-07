using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 21.65;
            //strawberryPrice = 45.69;
            //potatoPrice = 13.55;
            //tomatoPrice = 25.95;

            //Console.WriteLine("====>> Elma Birim Fiyatı: " + applePrice+" TL");
            //Console.WriteLine("====>> Portakal Birim Fiyatı: " + orangePrice+" TL");
            //Console.WriteLine("====>> Çilek Birim Fiyatı: " + strawberryPrice+" TL");
            //Console.WriteLine("====>> Patates Birim Fiyatı: " + potatoPrice+" TL");
            //Console.WriteLine("====>> Domates Birim Fiyatı: " + tomatoPrice+" TL");

            //Console.WriteLine();
            //Console.WriteLine("****** Fiyat Listesi ******");

            //double appleGram, orangeGram, strawberryGram,potatoGram, tomatoGram;

            //appleGram = 1.250;
            //orangeGram = 3.455;
            //strawberryGram = 0.969;
            //potatoGram = 4.675;
            //tomatoGram = 2.768;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;

            //orangeTotalPrice = orangeGram * orangePrice;

            //strawberryTotalPrice = strawberryGram * strawberryPrice;

            //potatoTotalPrice = potatoGram * potatoGram;

            //tomatoTotalPrice = tomatoGram * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("------- Ürün Tutarları -------");
            //Console.WriteLine();
            //Console.WriteLine("Elma Toplam Tutarı :" + appleTotalPrice);
            //Console.WriteLine("Portakal Toplam Tutarı :" + orangeTotalPrice);
            //Console.WriteLine("Çilek Toplam Tutarı :" + strawberryTotalPrice);
            //Console.WriteLine("Patates Toplam Tutarı :"+ potatoTotalPrice);
            //Console.WriteLine("Domates Toplam Tutarı :"+ tomatoTotalPrice);
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("******* Ödenecek Toplam Tutar ********");

            //double totalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine() ;
            //Console.WriteLine("Alışveriş Toplam Tutarı : "+totalPrice);
            //Console.WriteLine("*** İyi Günler Dileriz ***");
            //Console.WriteLine();
            //Console.WriteLine("******* Ödenecek Toplam Tutar ********");




            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol = 'M';

            //Console.WriteLine(symbol);
            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** Yazar Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı :");
            //passengerName= Console.ReadLine();
            //Console.Write("Yolcu Soyadı :");
            //passengerSurname= Console.ReadLine();
            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict= Console.ReadLine();
            //Console.Write("Şehir Bilgisi :");
            //passengerCity= Console.ReadLine();
            //Console.Write("Yolcu Yaşı :");
            //passengerAge= Console.ReadLine();
            //Console.Write("Yolcu Kimlik No :");
            //passengerIdentityNumber= Console.ReadLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("******  Yolcu Bilgileri  *******" );
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Adı Soyadı :" + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu İlçe Bilgisi :"+passengerDistrict);
            //Console.WriteLine("Yolcu Şehir Bilgisi :"+passengerCity);
            //Console.WriteLine("Yolcu Yaşı :"+passengerAge);
            //Console.WriteLine("Yolcu Kimlik No :"+passengerIdentityNumber);
            //Console.WriteLine("---------------------------------");








            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 4000;
            //tvPrice = 13000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Adedini Giriniz :");
            //shoesCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Adedini Giriniz :");
            //computerCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen Aldğınız Sandalye Adedini Giriniz :");
            //chairCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Tv Adedini Giriniz :");
            //tvCount = int.Parse( Console.ReadLine());


            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();

            //Console.Write("Ödemeniz Gereken Toplam Tutar :" + totalPrice + " Tl' dir.");

            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri 

            //double exam1, exam2,exam3,result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz :");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz :");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("LKütfen 3. Sınav Notunu Giriniz :");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1 +exam2 +exam3)/3;

            //Console.WriteLine();

            //Console.Write("Sınav Ortalamanız :"+result);

            #endregion


            #region Klavyeden Karakter Girişleri 

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz :");

            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet :" + gender);




            #endregion

            Console.Read();
        }
    }
}
