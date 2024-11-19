
using System.Security.Cryptography.X509Certificates;
using System.Linq;

public class RehberListeleme:NumaraEkleme{
    
    public void Listele(){

        string yanit;
        
        Console.Clear();

        Console.WriteLine("A'dan Z'ye sırala (1)");
        Console.WriteLine("Z'dan A'ye sırala (2)");
        yanit=Console.ReadLine();

        while (!KontrolEt(yanit, "1","2"))
        {
            Console.WriteLine("Geçersiz giriş, lütfen 1 veya 2 seçeneklerinden birini seçin!");
            yanit=Console.ReadLine();
        }


        if (yanit=="1")
        {

            Console.Clear();

            //orderby metodu ile isim özelliğine göre sırala
            List<Kisi> AZsirali = Rehber.Rehberim.OrderBy(kisi => kisi.Isim).ToList();
            
            foreach (var kisi in AZsirali)
            {
                Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, numara: {kisi.Numara}");
            }
        }

        if (yanit=="2")
        {

            Console.Clear();

            List<Kisi> ZAsirali = Rehber.Rehberim.OrderByDescending(kisi => kisi.Isim).ToList();

            foreach (var kisi in ZAsirali)
            {
                Console.WriteLine($"İsim: {kisi.Isim}, Soyisim: {kisi.Soyisim}, numara: {kisi.Numara}");
            }

        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Ana menüye dönmek için bir tuşa basın.");
        Console.ReadLine();

    }

    public override bool KontrolEt(string girdi, params string[] dogruSecenekler)
    {
        return base.KontrolEt(girdi, dogruSecenekler);
    }
}