using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu

            //foreach(1;2;3;4)

            //1: Değişken türü
            //2: Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = {"Milano", "Roma", "Budapeşte", "Ankara", "İstanbul","Varşova" };

            //foreach (string city in cities)
            //{
            //   Console.WriteLine(city);
            //}

            //int[] numbers = {45, 78, 985, 635, 74, 11, 22, 33,
            //41, 205, 6578, 10394};

            //foreach (int i in numbers) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //int[] numbers = {45, 78, 985, 635, 74, 11, 22, 33,
            //41, 205, 6578, 10394};

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = {45, 78, 985, 635, 74, 11, 22, 33,
            //41, 205, 6578, 10394};

            //int total = 0;

            //foreach (int number in numbers) 
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers) 
            //{ 
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion


            #region Ornek Sinav Sistemi
            //Klavyeden öğrenci sayısı
            //Klavyeden öğrenci ismi
            //Öğrencilerin sınav notları
            //Ortalamaları
            
            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması ***** ");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            //Console.WriteLine("------------------------------");
            //Console.Write("Öğrenci Sayısını Giriniz: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAverage = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} Adlı Öğrencinin {j+1}. Sınav Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine("");
            //    studentExamAverage[i] = totalExamResult / 3;
            //}
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExamAverage[i]}");

            //    if (studentExamAverage[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı.");
            //    }
            //    Console.WriteLine("------------------------------");
            //}
           
            #endregion

            Console.Read();
        }
    }
}
