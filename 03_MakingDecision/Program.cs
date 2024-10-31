using System;
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

            //Console.Write("Lütfen Parolayı Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Parola Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Parola Yanlış.");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == ("ankara") & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı. ");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi. ");
            //}

            //int number;
            //Console.Write("Sayı Giriniz. ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayı Doğru. ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı. ");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 71 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut. ");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil. ");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz. ");
            //string userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Kabul Edilemez. ");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz. ");
            //}

            #endregion

            #region Mod Islemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen Birinci Sayıyı Giriniz. ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen İkinci Sayıyı Giriniz. ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: " + result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir. ");
            //}
            //else 
            //{
            //    Console.WriteLine("Sayı Tektir. ");
            //}

            #endregion

            #region Char Degiskenler Ile Karar Yapilari

            //char team;

            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team =='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("******C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını Görmek İstediğiniz Menüyü Seçin");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk. ");
            //    Console.WriteLine("2-Kızartma Tabağı. ");
            //    Console.WriteLine("3-Fsaulye Pilav. ");
            //    Console.WriteLine("4-Fırında Somon. ");
            //    Console.WriteLine("5-Patlıcan Musakka. ");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek. ");
            //    Console.WriteLine("2-Ezogelin. ");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz. ");
            //    Console.WriteLine("2-Margaritha. ");
            //    Console.WriteLine("3-Tavuklu. ");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola. ");
            //    Console.WriteLine("2-Ayran. ");
            //    Console.WriteLine("2-Su. ");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe. ");
            //    Console.WriteLine("2-Kazandibi. ");
            //    Console.WriteLine("2-Sütlaç. ");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();

            //}



            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız. ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("Birinci Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine()); 

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-': 
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
                     
            //}
            #endregion
            Console.Read();
        }
    }
}
