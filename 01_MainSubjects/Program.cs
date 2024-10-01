using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    //program çalıştığında ayağa kalkacağı sınıf = "Program" sınıfı.
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya"); // imleç alt satıra gelir.
            //Console.Write("selam"); //imleç en sağa gelir.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region stringDegiskenler

            //string

            //string name;
            //name = "Ahmet";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Hamza";
            //customerSurname = "PEKPAK";
            //customerPhone = "+90 553 133 92 86 86";
            //customerEmail = "parlak@gmail.com";
            //district = "Aydınlık";
            //city = "Konya";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri: " +  customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            //customerName = "Beyza";
            //customerSurname = "PARLAK";
            //customerPhone = "+90 0553 130 13 13";
            //customerEmail = "parlak@gmail.com";
            //district = "Meram";
            //city = "Konya";


            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------");

            #endregion

            #region ıntDegiskenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            //int baklavaPrice = 150;

            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();
            //Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("----Pizza: " + pizzaPrice + "TL");
            //Console.WriteLine("----Kola: " + cokePrice + "TL");
            //Console.WriteLine("----Limonata: " + lemonadePrice + "TL");
            //Console.WriteLine("----Kızarma Tabağı: " + friesPrice + "TL");
            //Console.WriteLine("----Su: " + waterPrice + "TL");
            //Console.WriteLine("----Bakalava: " + baklavaPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();

            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;
            //int baklavaCount;
            
            //int totalHamburgerPrice = 0;
            //int totalCokePrice = 0;
            //int totalWaterPrice = 0;
            //int totalFriesPrice = 0;
            //int totalPizzaPrice = 0;
            //int totalLemonadePrice = 0;
            //int totalBaklavaPrice = 0;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;
            //baklavaCount = 2;

            //totalHamburgerPrice = hamburgerPrice*hamburgerCount;
            //totalCokePrice = cokePrice * cokeCount;
            //totalWaterPrice = waterPrice * waterCount;
            //totalFriesPrice = friesPrice*friesCount;
            //totalPizzaPrice = pizzaCount * pizzaCount;
            //totalLemonadePrice = lemonadeCount * lemonadeCount;
            //totalBaklavaPrice = baklavaPrice * baklavaCount;

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("----**** Adisyon ----****");
            //Console.WriteLine("Hamburger Adet Fiyatı: " + hamburgerPrice + "TL" );
            //Console.WriteLine("Sipariş verilen Hamburger Adedi: " + hamburgerCount);
            //Console.WriteLine("Hamburger için ödenmesi gereken tutar -->" + totalHamburgerPrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Kola Adet Fiyatı: " + cokePrice + "TL");
            //Console.WriteLine("Sipariş verilen Kola Adedi: " + cokeCount);
            //Console.WriteLine("Kola için ödenmesi gereken tutar -->" + totalCokePrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Su Adet Fiyatı: " + waterPrice + "TL");
            //Console.WriteLine("Sipariş verilen Su Adedi: " + waterCount);
            //Console.WriteLine("Su için ödenmesi gereken tutar -->" + totalWaterPrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Kızartma Tabağı Adet Fiyatı: " + friesPrice + "TL");
            //Console.WriteLine("Sipariş verilen Kızartma Tabağı Adedi: " + friesCount);
            //Console.WriteLine("Kızartma Tabağı için ödenmesi gereken tutar -->" + totalFriesPrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Pizza Adet Fiyatı: " + pizzaPrice + "TL");
            //Console.WriteLine("Sipariş verilen pizza Adedi: " + pizzaCount);
            //Console.WriteLine("pizza için ödenmesi gereken tutar -->" + totalPizzaPrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Limonata Adet Fiyatı: " + lemonadePrice + "TL");
            //Console.WriteLine("Sipariş verilen Limonata Adedi: " + lemonadeCount);
            //Console.WriteLine("Limonata için ödenmesi gereken tutar -->" + totalLemonadePrice + "TL");
            //Console.WriteLine("-----------------------------");

            //Console.WriteLine("Baklava Adet Fiyatı: " + baklavaPrice + "TL");
            //Console.WriteLine("Sipariş verilen Baklava Adedi: " + baklavaCount);
            //Console.WriteLine("Baklava için ödenmesi gereken tutar -->" + totalBaklavaPrice + "TL");
            //Console.WriteLine("-----------------------------");

            //int totalPrice = 0;
            //totalPrice = (totalHamburgerPrice + totalCokePrice +
            //    totalWaterPrice + totalFriesPrice +
            //    totalPizzaPrice + totalLemonadePrice + totalBaklavaPrice);

            //Console.WriteLine("Toplam Sipariş Tutar: " + totalPrice + "TL");

            #endregion

            Console.Read(); // konsolun gözükmesi enter tuşuna basınca kapan kodu.
        }
    }
}




