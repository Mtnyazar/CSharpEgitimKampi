
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreeach Döngüsü

            //string[] cities = { "İstanbul", "Ankara", "Bursa", "Konya", "Artvin","İzmir" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //};




            #endregion


            #region Örenk Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");

            Console.Write("Sınıfınızda Kaç Öğrenci Var :");

             int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");


            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.Öğrencinin İsimini Giriniz :");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her Öğrenci için 3 Sınav Notu Girilecek



                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz :");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value;
                    Console.WriteLine("---------------------------------");
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult/3;
                
            }

            //Öğrencilerin Ortalaması VE Geçip Kalma Durumları

            Console.WriteLine("**** Öğrenci Durumları ******");
            Console.WriteLine();

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı Öğrencinin Ortalaması :{studentExamAvg[i]}");  

                //Öğrencilerin Ortalaması ve Geçip Kalma Durumları

                if ( studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli Öğrenci Dersi Geçti.");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli Öğrenci Dersten Kaldı");
                    Console.Beep();
                }
                Console.WriteLine("--------------------------------------") ;
            }

            #endregion
            Console.Read();
        }
    }
}
