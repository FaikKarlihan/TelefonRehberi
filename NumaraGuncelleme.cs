using System.Net.Sockets;
using System.Reflection.Metadata;

public class NumaraGüncelleme:NumaraEkleme{

    string cikisyanit;
    string arananKisi;
    string isimNew, soyisimNew, numaraNew;
    
    public void Güncelle(){

        do
        {
        Console.Clear();
        bool bulundu=false;

        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını girin: ");
        arananKisi = Console.ReadLine();

        foreach (var kisi in Rehber.Rehberim)
        {
            if (arananKisi.Equals(kisi.Isim, StringComparison.OrdinalIgnoreCase)
                || arananKisi.Equals(kisi.Soyisim, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine($"Lütfen {kisi.Isim} {kisi.Soyisim} isimli kişi için güncel bilgileri girin.");
                Console.WriteLine("------------------------------------------------------------");
                // kişi bilgileri alınıp atamaları yapılır 
                Console.Write("İsim:    "); isimNew=Console.ReadLine(); kisi.Isim = isimNew;
                Console.Write("Soyisim: "); soyisimNew=Console.ReadLine(); kisi.Soyisim = soyisimNew;
                Console.Write("Numara:  "); numaraNew=Console.ReadLine(); kisi.Numara = numaraNew;
                Console.Clear();
                Console.WriteLine("Kişi başarıyla güncellendi!");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Ana menüye dönmek için(1)");
                Console.WriteLine("Tekrar denemek için(2)");
                cikisyanit=Console.ReadLine();

                while (!KontrolEt(cikisyanit, "1","2"))
                {
                Console.WriteLine("Geçersiz giriş lütfen '1' veya '2' seçeneklerinden birini seçin!");
                cikisyanit=Console.ReadLine();
                }

                bulundu = true;
                break;
            }
        }

        if (!bulundu)
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

        } while (cikisyanit=="2");

    }

    public override bool KontrolEt(string girdi, params string[] dogruSecenekler)
    {
        return base.KontrolEt(girdi, dogruSecenekler);
    }

}