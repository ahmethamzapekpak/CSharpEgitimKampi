==> Merhabalar projemi sizlerle paylaşmaktan onur ve gurur duyuyorum. Hem kendimi geliştirdiğim hem de sizlerin faydalanmasını faydalanacağını umduğum projemde C# temel 101 eğitimi üzerine olacaktır. Projede Emeği Geçen Hocam Murat Yücedağ'a saygı ve sevgilerimle.<==


📍 Proje1 -->  Birinci kısımda İlk olarak temel yazdırma komutları ve değişkenler üzerine olacaktır ve Üç ana başlık altında birinci kısmı bitireceğiz, bu başlıklar sırasıyla;
	1-)Yazdırma Komutları
		İlk ders ilk kod olduğu için ilk olarak konsol ekranımızda "Merhaba Dünya" yazdırmak oldu. Bunun için öğreneceğimiz iki adet komutumuz var. Bunlardan ilki -Console.Write()- bu komut ekrana mesaj gönderir lakin imleci mesajın hemen yanında bırakır. 
    Bu komuttan sonra başka bir mesaj verilecek veya bir ifade gelecekse hemen yanı başına gelir bu istemiyorsak diğer komutumuz olan -Console.WriteLine()- kullanırız bu komut ise mesajı gönderdikten sonra imleci bir alt satıra gönderir. 
    Örnek uygulamamızda Yemek kategorileri kartı yaptık bunları alt alta ekrana yazdırdık. 
    
	2-)String Değişkenler 
		Bu kısımda ise ekrana mesaj yazdırmaktan ziyade string bir değişken kullancağız ve bu değişkeni ekrana yazdıracağız. String değişkenler metinsel ifadeleri tutmak için kullanılır. 
    String bir ifade tanımlamak için şu şekilde bir syntax kullanılmalı: string _Değişkenİsmi; daha sonra bu string değişken ekrana yazdırıldığında mesaj vermek yerine değişkene tanımlı olan ifadeyi ekrana yazdırmış oluruz.
    Uygulamamızda bir kişinin bilgilerini tutan kart yaptık bunları bir değişkenden çekerek ekrana yazdırdık.
    
	3-)Int Değişkenler
		İnteger değişkenlerde string değişkenlere benzer lakin integer değişkenler sayısal verileri tutmak için kullanılır. Mesela bir matematiksel işlem yapılması gerekiyorsa değişken türümüz integer olmalı örnek uygulamamızda daha iyi anllaşılacaktır.
    Uygulamamızda bir restorantın yiyecek ve içecek fiyatları var restoranta gelen bir kişinin hangi üründen ne kadar yediği ve ne kadar ücret ödemesi gerektiğini hesaplayan bir kod yazdık.


📍 Proje2 --> İkinci kısımda biraz daha değişkenler ve kullanıcıdan veri alma üzerinde duracağız. Dört adet konu başlığında inceleyeceğiz, bu konu başlıkları sırasıyla;
	1-)Double Değişkenler
		Double değişkenler ondalıklı sayılarla işlem yapmamız gerektiğinde kullancağımız kullanabilceğimiz bir veri türüdür.Mesela uygulamamızda da olduğu üzere bir manavda satılan ürünlerin fiyatını hesaplarken eğer integer kullanırsak hatalı bir yol izlemiş oluruz.
    Çünkü bir ürünün kilogram fiyatı ondalıklı olabilir ürün kilogramıda ondalıklı olabilir bu yüzden double kullanarak daha sağlıklı sonuçlar elde edebiliriz.
    Uygulamıza gelecek olursakta bir manavda satılan ürünlerin fiyatları ve müşterinin aldığı kilograma göre toplam fiyat veren kodu yazdık. Ürün fiyatları double değişkeni ile belirlendi matematiksel işlemler yapıldı, toplam sonuç ekrana yazdırıldı.
    
	2-)Char Değişkeni
		Char değişkeni tek bir karkter tutmaya yarar bir bittir. Bir veriyi veya kullanıcıdan aldığımız alacağımız bir bitlik veri varsa bu değişkeni kullanabiliriz. Hem güvenlik hem de depolama tasarrufu için kullanışlıdır.
    Aynı zamanda ekrana da char değişkeni ile atadığımız bir veriyi yazdırabiliriz.
    
	3-)Veri Dönüşümleri
		Veri dönüşümleri yazdığımız kodların stabil çalışması için gereklidir. Bilgisayar kullancıdan aldığımız verileri string türünde alır ve bizimde bu veriler ile matematiksel bir işlem yapmamız gerekiyorsa dönüşüm yapmadan bilgisyar buna olanak sağlamaz.
    Yani dönüşüm yapmamızı ister, peki dönüşümü nasıl yapacağız birde ona bakalım.Dönüşüm için gerekli olan aslında çok küçük ama gerekli olan kod parçası -int.Parse(Console.ReadLine())- budur. Dönüşümü yaptığımıza göre matematiksel işlemleri yapmaya hazırız :).
    
	4-)Kullanıcıdan Veri Alma İşlemleri
		Sıra geldi kullanıcıdan veri almaya bunun içinde basit bir kod parçası var onu yapacağız ama bir örnek uygulama yapıp şimdiye kadarkı bilgileri hem tekrar hem de pekiştirmiş olacağız. İlk olarak kod parçasından söz edeyim sonra uuygulamayı anlatmaya geçeriz.
    Kod parçamız değişkenimizi oluşturup -Console.ReadLine()- Bu kodu eklemek.Örneği incelediğimizde daha iyi anlaşılacaktır. Örneğimizde C# hava yolları yolcu bilgi sistemi almak istediğimiz bilgiler için ekrana mesaj gönderiyoruz.
    Yolcunun girdiği cevapları kod parçamız sayesinde hafızaya kaydediyor ve bu bilgileri kulanabiliyoruz.


📍 Proje3 --> Üçüncü kısımda karak yapıları ve örnek uygulamamız olacak bu kısmı dört başlık altında inceleyeceğiz;
	1-)If - Else Yapıları
		If - Else yani karar yapıları bir kontrol mekanizmasıdır aslında yani ifadenin doğru olup olmadığını kontrol eder doğru ise farklı yanlış ise farklı davranmayı sağar mesela parola doğrulaması gibi düşünürsek doğru ise sisteme erişim açılacaktır. 
    Değil ise parola yanlış yantını döndürecek sisteme erişim izni verilmeyecektir. Örnek uygulamamızda da parola doğrulama sistemi var.
    
	2-)Mod işlemi
		Mod işlemi bir sayının başka bir sayıya modu o sayıya bölündüğünde ki en küçük kalanı veren matematiksel bir işlemdir. Bir sayının modunu almak için % işaretini kullanırız.
  
	3-)Örnek Uygulama
		Uygulamamızda bir restorantın yiyecek ve içecek kategorileri var ve bu kategorilerinde her birinde o kategoriye ait farklı yiyecek ve içecek türleri var.
    Müşteriye detayını görmesini istediği menüyü soruyoruz ve karar yapıları kullanarak kontrol sağlıyor ve görmek isteidği menüyü mesela çorbalar kategorisini seçmişse kodu çorba türlerini gösteren kısma gitmesini sağlayıp çorba çeşiterini ekrana yazdırıyoruz.

	4-)Switch - Case Yapısı
		Switch-case yapısı if-else yapısına benzer çalışır farkı ise if-else gibi tüm şartları kontrol etmez aksinse istenilem şartı bulur çalıştırı işlemş yapar ve yapıdan çıkar.
    Örnek olarak hesap makinesi yaptık işlem toplama işlemi ise program toplama işlemi kısmına gidiyor işlemi yapıp çıkıyor veya çıkarma, çarpma ve bölme isede değişen olmuyor sadeceistenilen yapılıyor ve program duruyor.


📍 Proje4 -->Dördüncü kısımda for döngüsü, while döngüsü ve örnek soru olacak bu kısmı üç başlık altında inceleyeceğiz;
	1-)For Döngüsü
		For döngüsü listeler dizi yapıları veya işlem bitene kadar çalışmasını istediğimiz yapıları kullanırken faydalanacağımız kullanım alanı geniş olan bir döngüdür karar yapıları ile birliktede kullanımını örnek kod parçamızda gördük.
    Kullanımı syntax kısmı şu şekildedir: -for(x;y;z)- burada "x" ifadesi başlangıç değerini "y" ifadesi bitiş değerini "z" ifadesi ise artış-azalış değerini tutar.Örnek uygulamamızda bir mesajımız var ama bu mesajı beş kez ekrana yazdırmak isityoruz.
    Bunun için mesajı beş kez kopyala yapıştır yapmak yerine bir for döngüsü içerisine alıyoruz başlangıç değerini bir bitiş değerini beşe eşit veya küçük olarak ayarlıyor artış miktarını bir yapıyoruz bu sayede ekrana beş kez mesajımız yazılmış oluyor.
    İkinci örneğimiz ise karar yapısı ile beraber kullanımı üzerine burada belirlediğmiz aralıktaki sayıların çift veya tek olanları toplamasını istiyoruz bunun için toplam değerini sıfır belirliyoruz.
    Sonra döngümüzü oluşturuyoruz ve ekrana yeni toplam değeri yazdırıyoruz
    
	2-)While Döngüsü 
		While döngüsü sonsuz döngü demektir yani bir olayın gerçekleşmesi bir şarta bağlanmışsa ve bu şart sağlanıyorsa ve programın ne zaman duracağı belirtilmemişse sürekli çalışır.
    Örneğimize bakacak olursak başlangıç olarak atadığımız değer üst sınır olarak belirlediğimiz yere gelinceye kadar çalışıyor ama her defasında başlangıç değerimizi bir arttırıyor bu sayede program üst sınır değerine ulaşınca döngü sonlanmış oluyor.
    Ekrana istediğmiz işlemler yazılıyor veya yapılıyor.
    
	3-)Örnek Soru
		Sorumuz "Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.?" bunun için değişken atamalarımızı yapıyoruz ardından mod işleminden faydalanmamız gerekiyor.
    Birler basamağı için sayının 10 ile modunu alıyoruz, Onlar basamağı için 100 ile modunu alıp sayıyı tekrar 10'a bölüyoruz değişkenimizi integer attadığımız için ondalıklı sayı gelmiyor.
    Daha sonra yüzler basamağı içinse sayıyı 100'e bölüyoruz sonra teker teker ekrana yazdırıyoruz sorumuzu tamam oluyor.


📍 Proje5 --Beşinci kısımda altı adet örneği ele alacağız bol bol örnek içeren bu kısımda şimdiye kadar öğrendiklerimizin neredeyse hepsini kullanmış olacağız;
	1-)Örnek
		Alt alta 10 tane yıldız oluşturduğumuz kodumuzda başlangıç değeri için 1 ve programın 10'a küçük veya eşit olana kadar devam etmesini her seferinde başlangıç değerinin bir artmasını içeren for döngüsünü yazdık. 
    For döngüsünün içerisine ise -Console.WriteLine("*")- komutunu yazarak alt alta 10 adet yıldız yazdırmış olduk. 
    Dikkat! ilk dersimizde öğrenmiş olduğumuz ekrana iki farklı yazdırma komutundan birisi olan -Console.WriteLine("*")- komutunu kullandık -Console.Write("*")- komutunu değil.
    
	2-)Örnek
		Yan yana 10 tane yıldız oluşturduğumuz kodumuzda başlangıç değeri için 1 ve programın 10'a küçük veya eşit olana kadar devam etmesini her seferinde başlangıç değerinin bir artmasını içeren for döngüsünü yazdık.
    For döngüsünün içerisine ise -Console.Write("*")- komutunu yazarak alt alta 10 adet yıldız yazdırmış olduk. 
    Dikkat! ilk dersimizde öğrenmiş olduğumuz ekrana iki farklı yazdırma komutundan birisi olan -Console.Write("*")- komutunu kullandık -Console.WriteLine("*")- komutunu değil.
    
	3-)Örnek
		Alt alta ve yan yana 10 tane yıldız oluşturduğumuz kodumuzda başlangıç değeri için 1 ve programın 10'a küçük veya eşit olana kadar devam etmesini her seferinde başlangıç değerinin bir artmasını içeren for döngüsünü yazdık.
    For döngüsünün içerisine ise -Console.WriteLine("**********")- komutunu yazarak alt alta 10 adet yıldız yazdırmış olduk. İlk örnekten farkı sadece -Console.WriteLine("*")- içerisindeki yıldız sayısının 10 adet olması.
    
	4-)Örnek
		Dik üçgen çizme örneğimizde ise başlangıç değeri için 1 ve programın 5'e küçük veya eşit olana kadar devam etmesini her seferinde başlangıç değerinin bir artmasını içeren for döngüsünü yazdık.
    For döngüsünün içerisine ise tekrar bir for döngüsü açtık aynı şekilde başlangıç değeri için 1 verdik lakin döngü o an "i" değeri neyse o kadar çalışsın dedik yani ilk döngü çalışacak "i" değeri 1 olacak.
    Sonra ikinci döngü çalışacak bakacak "i" değeri 1 ikinci döngüde 1 kez yıldız yazacak ilk döngüde "i" değeri 2 olacak ikinci döngü bu sayede iki kez çalışacak ve iki kez yıldız yazacak böyle böyle ilk döngü 5 kez çalışınca ekrana dik üçgen motifi çıkmış olacak.
    
	5-)Örnek
		Ters dik üçgen çizme örneğimizde ise başlangıç değeri için 5 ve başlangıç değerinin 1'e küçük veya eşit olana kadar devam etmesini her seferinde başlangıç değerinin bir azalmasını içeren for döngüsünü yazdık.
    For döngüsünün içerisine ise tekrar bir for döngüsü açtık aynı şekilde başlangıç değeri için 1 verik başlangıç değeri "i" ye küçük veya eşit olana kadar çalışacak.
    Lakin bu kez bir artacak her seferinde ve ilk döngü 5 kez çalışınca ekrana ters dik üçgen motifi oluşacaktır.
	6-)Örnek
		Ters piramit oluşturma örneğimizde ise "n" adında integer bir değer oluşturup 5 değerini veriyoruz. For döngüsünü açıp başlangıç değerini "n" değerine atıyoruz "i" değerini büyük veya eşit 5 olana kadar diyip her seferinde bir azaltıyoruz.
    Amacımız o çünkü daha sonra bu döngünün içerisinde iki adet daha döngü açıyoruz ilk döngü boşluk atacak ekranın solundan itibaren ikinci döngü ise yıldız yazacak böylece ters piramit oluşacak.


📍 Proje6 -->Altıncı kısımda diziler üzerine ele alacağız örnekler yapılar olmak üzere Dört Başlık altında inceleyeceğiz;
	1-)Temel Dizi Örnekleri
		Diziler aynı türden ifadeleri bir arada tutmaya yarar. Dizileri tanımlarkan izlediğimiz yol şudur: -DeğişkenTürü [] DiziAdı = new DeğişkenTürü[elemansayısı]- bu şekilde istediğimiz dizileri tanımlarız dizilerin indisi eğer biz belirtmemişsek "[0]" sıfır ile başlar. 
  
	2-)Dizideki Elemanları Listeleme
		Dizileri listelemek için if ve for yapılarını kullanacağız. Örneğimize bakacak olursak colors isminde bir dizimiz var içerisinde 7 adet rengimiz var bunları ekrana yazdırmak için for döngümüzü açıyoruz.
    Başlangıç değerini(i) 0 yapıyoruz ve "i" değerini C# sınfından yararlanarak dizimizin adı yani color.length yapıyoruz.
    "i" değerimizi 1 arttırıyoruz her seferinde ve döngünün içerisinde ekrana yazdırma komutumuzu yazdırıp parantez içerisine döngümüzdeki "i" değişkenini yazıyoruz. 
		
	3-)Dizi Methotları
		Dizilerin indis değerlerini değiştirebiliriz mesela içerisinde 5 değer olan  dizinin son indisindeki değer yani [4]=ahmet olsun biz bunu değiştirip mehmet yapabiliriz bunun için kullanacağımız kod -Array.IndexOf(customers,"mehmet")- bloğudur.
    Dizi içerisinde matematiksel işlemler de yapabiliriz örneğin dizinin içerisindeki en  üyük ve en küçük değerleri max ve min değerleri ile çekip toplama yaptırabiliriz.
	
	4-)Kullanıcıdan Değer Alma
		Dizileri sadece kendimiz veri girerek değil kullanıcıdan veri alarakta oluşturabilriz bunun için boş bir dizi oluşturup boyutunu dizinin boyutunu belirleyerek başlıyoruz.
    Örneğimizdeki gibi cities dizisi oluşturup içerisindeki verileri kullanıcıdan isteyelim bunun için for döngüsü açıyoruz i değerini 0 yapıp i değeri cites dizisinin değerininden küçük veya eşit olana kadar her seferinde bir artsın diyoruz.
    Döngünün içerisine girip mesaj kısmına {i + 1} yapıyoruz ki her seferinde 1. şehri giriniz sonra 2. şehri giriniz gibi artarak gitsin tüm şehirleri böylece kllanıcıdan düzgün bir şekilde sırayla almış oluyoruz.


📍 Proje7 -->Yedinci kısımda foreach döngüsünü ele alacağız ve örnek soru olacak bu kısmı iki başlık altında inceleyeceğiz;
	1-)Foreach Döngüsü
		Foreach yapısı diziler üzerinde yineleme yapmayı kolaylaştırmaktadır. Foreach yalnızca diziler ve nesneler için kullanılabilir. Nesneler arası gezinmeyi sağlar.
    Kullanımı şöyle olmalıdır:  foreach(1;2;3;4) buradaki 1 ifadesi değişken türü 2 ifadesi değişken adı 3 ifadesi In kısmı 4 ifadesi ise liste, koleksiyon veya diziyi ifade eder  
		
	2-)Örnek Soru
		Örneğimizde Klavyeden öğrenci sayısı, Klavyeden öğrenci ismi, Öğrencilerin sınav notları ve Ortalamalarını hesaplayan programı yaptık;
    İlk olarak ekrana mesaj yazdırdık daha sonra kullanıcıdan öğrenci sayısını girmesini istedik ve bu sayıyı matematiksel işlem yapacağımızdan integer ifadesine dönüştürdük.
    Öğrenci isimleri ve notları için boş diziler oluşturduk. öğrenci isimleri için kullancıdan aldığımız öğrenci sayısı kadar dizi uzunluğuna izin verdik aynı şekilde sınav notları içinde.
    Daha sonra döngümüzü açtık "i" değerini 0 yaptık sonra "i" değeri küçüktür öğrenci sayısı ise "i" değerini 1 arttır dedik döngüye girdik. Dizileri kullanıcıdan almayı anlatıığımız kısımda olduğuu üzere {i + 1 } ifadesini kullanmayı unutmayalım.
    Daha sonra öğrenci isimlerini tuttuğumuz dizilerin indisini döngümüzdeki "i" değerine göre değişmesini ayarladık ynai [i] yaptık bunu -Console.ReadLine()- ile kullanıcıdan aldık.
    Ortalamları hesaplamak içinde benzer işlemleri yaptık lakin burada ondalıklı gelebileceği için double kullandık sınav notlarını toplayıp sınav adedine böldük ortalamayı bulduk.
    Şimdi ise sınav ortalaması 50 altında kalan öğrenciler için karar yapıları kullanarak dersten kaldığını 50 ve üzerinde ise başarılı sayıldığını hesaplayan ve ekrana yazdıran kısmıda yazıp sorumuzu tamamlamış olduk.


📍 Proje8 -->Sekizinci kısımda void mothotlar geriye değer döndürebilen ve döndüremeyen olarak ayrı başlıklarda ve örnek soru olacak bu kısmı dört başlık altında inceleyeceğiz;
	1-)Void Methotları
		Bir Yapıyı Method Yapan Şey ()'dir geriye değer döndüren ve döndürmeyen olarak sınfılandırılabilir.
		
	2-)Geriye Değer Döndürmeyen Methotlar
		Geri dönüş tipi olarak “void” kullanılır ve return bulunmaz. Void anahtar sözcüğü geri değer döndürmez. Parametre barındırmayan metotlarda parantez içi boş bırakılır. 
		
	3-)Geriye Değer Döndüren Methotlar
		Geriye veri döndürmeyen metotlardan ilk farkı burada void kullanılmamasıdır. Yukarıda da bahsedildiği üzere void kullanımının amacı geri değer döndürmemektir.
    Burada geri dönüş tipi olarak int, string gibi ifadeleri kullanabiliriz. Bir diğer fark ise artık return kullanırız.
		
	4-)Örnek Soru
		Uygulamamızda bir öğrncinin 3 adet sınavının ortalamasını alıp 50 den büyük ve eşitse geçtiği değilse kaldığını ekrana yazdıran uygulamamızı yazdık.







