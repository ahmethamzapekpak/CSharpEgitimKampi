using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu

            //for(x;y;z)
            //X: Başlangıç değerini tutar.
            //Y: Bitiş değerini tutar.
            //Z: Artış-azalış değerini tutar

            //int i;
            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı. ");
            //}

            //for (int i = 1; i <= 20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrana Yaılmasını İstediğiniz Adedi Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Atam Sultan Fatih");
            //}

            #endregion

            #region For Dongusu Ile Karar Yapilari

            //for (int i = 1; i <= 100 ; i++) 
            //{ 
            //    if (i % 5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++) 
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalCift = 0;

            //for (int i = 0; i < 20; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalCift +=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalCift);

            //int sayac = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac);

            //int bacterium = 1;

            //for (int i = 1; i <=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i +". Saat sonunda: " + bacterium);
            //}
            #endregion

            #region While Dongusu

            //while(şart)
            //{
            //     işlemler
            //}

            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);   
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;    
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Ornek Sinav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred, sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundred = number / 100;
            //sum = ones + tens + hundred; 

            //Console.WriteLine("-------");
            //Console.WriteLine(ones);
            //Console.WriteLine("-------");
            //Console.WriteLine(tens);
            //Console.WriteLine("-------");
            //Console.WriteLine(hundred);
            //Console.WriteLine("-------");
            //Console.WriteLine(sum);

            #endregion


            Console.Read();
        }
    }
}
