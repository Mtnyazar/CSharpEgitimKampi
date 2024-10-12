using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri


            //string[] colors = new string[4];

            //colors[0] = "red";
            //colors[1] = "yellow";
            //colors[2] = "white";
            //colors[3] = "black";


            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //string[] cities = { "Prag", "Roma", "Berlin", "Ankara", "Bursa" };

            //Console.WriteLine(cities);


            #endregion


            #region Dizideki tüm ELemenaları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i<=colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] chars = { 'a', 'b', 'c' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] myArray = { 23, 42, 45, 231, 6969, 456, 768, 789, 898 };

            //int maxNumber= myArray[0];

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //        maxNumber = myArray[i]; 
            //    }

            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "MEtin", "Mehtap", "Miray", "Ahmet Kaan" };

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i]);
            //};
            //Console.WriteLine();
            //Console.WriteLine("Dizinin Uzunluğu :"+persons.Length);

            //int[] numbers = { 31,69,52,68,72,55,96 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion


            #region Dizi Metotları

            //string[] persons = { "MEtin", "MEhtap", "Miray", "Ahmet Kaan" };
            //int index = Array.IndexOf(persons, "MEhtap");


            //for (int i = 0; i < persons.Length; i++)
            //{

            //    Console.WriteLine(persons[i]);


            //}
            //Console.WriteLine("MEtin İndex No :"+index);



            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Girniz : ");
            //    cities[i] = Console.ReadLine();

            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);


            //int[] numbers = { 10, 20, 30, 40, 59 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //};
            //Console.WriteLine(sum);

            //int [] numbers = {21,42, 33, 54, 65,567,678,679,220};

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion



            Console.Read();
        }
    }
}
