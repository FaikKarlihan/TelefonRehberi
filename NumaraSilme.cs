using System.Security.Cryptography;

public class NumaraSilme:NumaraEkleme{

    string cikisyanit ="1";

    public void Sil(){

        do
        {
        Console.Clear();
        bool bulundu = false;

        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
        string silinecek = Console.ReadLine();
        
        
        foreach (var kisi in Rehber.Rehberim)
        {

            if (kisi.Isim.Equals(silinecek, StringComparison.OrdinalIgnoreCase)//silinecek olan kisi isim veya soyisimde var mı
                || kisi.Soyisim.Equals(silinecek, StringComparison.OrdinalIgnoreCase))
            {
            
                Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(e/h)");
                string silmeyanit =Console.ReadLine();    

                while (!KontrolEt(silmeyanit, "e", "h"))
                {
                    Console.WriteLine("Geçersiz giriş, lütfen 'e' veya 'h' seçeneklerinden birini seçin!");
                    silmeyanit=Console.ReadLine();
                }

                    if (silmeyanit=="e")
                    {

                    Console.Clear();
                    Rehber.Rehberim.Remove(kisi);
                    Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} isimli kişi rehberden silindi!"); 
                    
                    Console.WriteLine("* Ana menüye dönmek için    : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    cikisyanit = Console.ReadLine();

                    while (!KontrolEt(cikisyanit, "1","2"))
                    {
                    Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                    cikisyanit=Console.ReadLine();
                    }

                    }
                    else
                    {

                    Console.Clear();
                    Console.WriteLine($"{kisi.Isim} {kisi.Soyisim} isimli kişi hala rehberde");

                    Console.WriteLine("* Ana menüye dönmek için    : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    cikisyanit = Console.ReadLine();

                    while (!KontrolEt(cikisyanit, "1","2"))
                    {
                        Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                        cikisyanit=Console.ReadLine();
                    }

                    }
                bulundu=true; // eşleşme bulunup işlem gerçekleştirildiği için değişken true olarak ayarlanır
                break; // ve break komutuyla döngüden çıkılır

            }
        }

        if (!bulundu)// eşleşme olmadıysa 
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Ana menüye dönmek için    : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            cikisyanit = Console.ReadLine();

            while (!KontrolEt(cikisyanit, "1","2"))
            {
                Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
            }

            Console.Clear();
        }
            
        } while (cikisyanit=="2");
    }

    public override bool KontrolEt(string girdi, params string[] dogruSecenekler)
    {
        return base.KontrolEt(girdi, dogruSecenekler);
    }

}

