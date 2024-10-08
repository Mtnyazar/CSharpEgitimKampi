﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifrenizi Giriniz :");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş yaptınız !!!");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz :");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz :");
            //country = Console.ReadLine();

            //if(capital=="ankara"&country=="türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş Yaptınız");
            //}


            //int exam1, exam2, exam3, average;
            //string result="";

            //Console.Write("Sınav 1 :");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 :");
            //exam2=int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 :");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("**************");
            //Console.WriteLine("Sınav Ortalaması :" + average);

            //if (average >= 70)
            //{
            //    result = "Geçtiniz AA";
            //}
            //else if (average >= 69 || average >= 55)
            //{
            //    result = "Geçtiniz BB";
            //}
            //else
            //{
            //    result = "Kaldınız";
            //};

            //Console.WriteLine(result);

            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1.Sayıyı Giriniz :");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz :");
            //int number2=int.Parse(Console.ReadLine());

            //int result=number1%number2;

            //Console.WriteLine("Mod :"+result);

            //Console.Write("Lütfen Sayıyı Giriniz : ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0) 
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            //char team;
            //Console.Write("Lütfen Takım Harfini Giriniz :");

            //team =char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Seçtiğiniz Takım Galatasaray.");
            //}
            //else if (team =='f'|team=='F')
            //{
            //    Console.Write("Seçtiğiniz Takım Fenebahçe");
            //}
            //else if(team =='b'|team=='B')
            //{
            //    Console.Write("Seçtiğiniz Takım Beşiktaş");
            //};


            #endregion


            #region Örnek Proje Uygulaması

            //Console.WriteLine("******** C# Eğitim Kampı Restorant *******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Ana YEmekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Menu Detayı için Seçim Yapın :");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("1-Kızartma Tabağı");
            //    Console.WriteLine("1-Fasulye Pilav");
            //    Console.WriteLine("1-Fırında Somon");
            //    Console.WriteLine("1-Patlıcan Musakka");
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Tavuk Suyu");
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------ Pizzalar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine();
            //}






            #endregion


            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız :");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart");break;
            //    case 4: Console.Write("Nisan");break;
            //    case 5: Console.Write("Mayıs");break;
            //    case 6: Console.Write("Haziran");break;
            //    case 7: Console.Write("Temmuz");break;
            //    case 8: Console.Write("Agustos");break;
            //    case 9: Console.Write("Eylül");break;
            //    case 10: Console.Write("Ekim");break;
            //    case 11: Console.Write("Kasım");break;
            //    case 12: Console.Write("Aralık");break;
            //    default:Console.Write("Hatalı Giriş Yaptınız !!!");break;

            //}


            #endregion


            #region Switch Case Hesap Makinesi

            int number1, number2, result;

            char symbol;

            Console.Write("Birinci Sayıyı Giriniz ;");
            number1=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("İkinci Sayıyı Giriniz :");
            number2=int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz :");
            symbol=char.Parse(Console.ReadLine());
            Console.WriteLine();



            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam :"+result); 
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkan :" + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım :"+result);
                    break;
                case '/':  
                    result = number1 / number2;
                    Console.WriteLine("Bölüm :"+result);
                    break;
            }



            #endregion


            Console.Read();
        }
    }
}
