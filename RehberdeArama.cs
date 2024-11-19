using System.Linq.Expressions;

public class RehberdeArama:NumaraEkleme{

    string secimyanit; // arama yapma seçeneği
    string arananKisi;
    string arananNumara;
    string cikisyanit; // ana menüye dönmek veya işlme devam etmek

    public void Ara()
    {

    do
    {
    Console.Clear();
    bool bulundu=false; // aranan kişinin rehberde olup olmamasını kontrol

    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
    secimyanit=Console.ReadLine();

    while (!KontrolEt(secimyanit,"1","2"))
    {
        Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
        secimyanit=Console.ReadLine();
    }

    if (secimyanit=="1") // isim veya soyisime göre arama
    {
        Console.Clear();
        Console.WriteLine("Aramak istediğiniz kişinin ismini veya soyismini girin:");
        arananKisi=Console.ReadLine().Trim();

        foreach (var kisi in Rehber.Rehberim)
        {
            if (arananKisi.Equals(kisi.Isim, StringComparison.OrdinalIgnoreCase) 
                || arananKisi.Equals(kisi.Soyisim, StringComparison.OrdinalIgnoreCase))//aranan kişi rehberde vasrsa
            {
                Console.Clear();
                Console.WriteLine("Arama Sonuçlarınız: ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"İsim: {kisi.Isim}");
                Console.WriteLine($"Soyisim: {kisi.Soyisim}");
                Console.WriteLine($"Numara: {kisi.Numara}");
                Console.WriteLine("--------------------");

                Console.WriteLine("Ana menüye dönmek için(1) Tekrar denemek için(2)");
                cikisyanit=Console.ReadLine();

                while (!KontrolEt(cikisyanit, "1","2"))
                {
                Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
                }

                bulundu=true; // kişi rehberde bulunduğu için değişkene true atanır
                break; // istenilen işlem gerçekleştiği için döngüden çıkılır
            }   
        }

        if (!bulundu)//aranan kişi bulunmadıysa
        {
            Console.Clear();
            Console.WriteLine("Aranan kişi rehberde bulunamadı");
            Console.WriteLine("Ana menüye dönmek için(1) Tekrar denemek için(2)");
            cikisyanit=Console.ReadLine();

            while (!KontrolEt(cikisyanit, "1","2"))
            {
                Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
            }
        }
        
    }
    if (secimyanit=="2") //numaraya göre arama
    {
        Console.Clear();
        Console.WriteLine("Aramak istediğiniz kişinin numarasını girin:");
        arananNumara=Console.ReadLine();

        foreach (var kisi in Rehber.Rehberim)
        {
            if (arananNumara.Equals(kisi.Numara))
            {
                Console.Clear();
                Console.WriteLine("Arama Sonuçlarınız: ");
                Console.WriteLine("--------------------");
                Console.WriteLine($"İsim: {kisi.Isim}");
                Console.WriteLine($"Soyisim: {kisi.Soyisim}");
                Console.WriteLine($"Numara: {kisi.Numara}");
                Console.WriteLine("--------------------");

                Console.WriteLine("Ana menüye dönmek için(1) Tekrar denemek için(2)");
                cikisyanit=Console.ReadLine();

                while (!KontrolEt(cikisyanit, "1","2"))
                {
                Console.WriteLine("Geçersiz giriş, lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
                }

                bulundu=true; // kişi rehberde bulunduğu için değişkene true atanır
                break; // istenilen işlem gerçekleştiği için döngüden çıkılır

            }
        }

        if (!bulundu)//aranan kişi bulunmadıysa
        {
            Console.Clear();
            Console.WriteLine("Aranan kişi rehberde bulunamadı");
            Console.WriteLine("Ana menüye dönmek için(1) Tekrar denemek için(2)");
            cikisyanit=Console.ReadLine();

            while (!KontrolEt(cikisyanit, "1","2"))
            {
                Console.WriteLine("Geçersiz giriş, lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
            }
        }
        
    }

  
    } while (cikisyanit=="2"); //tekrar denemek için 2 seçildiyse işleme devam et

    }

    public override bool KontrolEt(string girdi, params string[] dogruSecenekler)
    {
        return base.KontrolEt(girdi, dogruSecenekler);
    }
}

