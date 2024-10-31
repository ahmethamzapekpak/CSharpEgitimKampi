using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methodlar
            ////Bir Yapıyı Method Yapan Şey () dir
            ////Geriye Değer Döndürmeyen Mothodlar VOİD

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Beyza Parlak");
            //    Console.WriteLine("Döndü beyza");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region Void Methodlar Geriye Deger Dondurmeyen String Methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("D.Beyza Parlak");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + "" + surName);
            //}
            //CustomerCard("Ahmet Hamza ", "Pekpak");
            //CustomerCard("D.Beyza ", "Pekpak");
            #endregion

            #region Void Methodlar Geriye Deger Dondurmeyen int Methodlar

            //void Sum(int x, int y, int z)
            //{
            //    Console.WriteLine(x + y + z);
            //}
            //Sum(2, 3, 4);

            #endregion

            #region Geriye Deger Donduren Methodlar

            //string CustomerName()
            //{
            //    return "Beyza Parlak";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Beyza";
            //    string surName = "Parlak";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Deger Donduren String Parametreli Methodlar

            //string CountryCard(string countryName, string capital, string flagClor)
            //{
            //    string cardInfo = "Ülke: " +countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagClor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye Deger Donduren Int Parametreli Methodlar

            //int Sum( int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(10, 3));
            //Console.WriteLine(Sum(8, 20));
            //Console.WriteLine(Sum(3, 6));

            #endregion

            #region Ornek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti. " + "Ortalaması: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci Sınavı Geçemedi. " + "Ortalaması: " + result; ;
                }
            }
            Console.WriteLine(ExamResult("Beyza", 75, 89, 100));
            Console.WriteLine(ExamResult("Ahmet", 20, 89, 10));

            #endregion

            Console.Read();
        }
    }
}
