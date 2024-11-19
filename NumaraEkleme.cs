using System.Security.Cryptography.X509Certificates;

public class NumaraEkleme{

    string yanit; // ekleme işleminin devamlılığının kontrolü için oluşturulan değişken
    public void Ekle(){

        do
        {
        Console.Clear();

        Console.Write("Lütfen isim giriniz             :"); string newIsim= Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz          :"); string newSoyisim= Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz :"); string newNumara = Console.ReadLine();
        

        Rehber.Rehberim.Add(new Kisi{ Isim=newIsim, Soyisim=newSoyisim, Numara=newNumara});
        //alınan girdilerle yeni bir kişi oluşturulur

        Console.WriteLine("Kişi başarıyla eklendi.");
        Console.WriteLine("Ana menüye dönmek için(1) Ekleme işlemine devam etmek için(2)");
        yanit=Console.ReadLine();

        while (!KontrolEt(yanit,"1","2"))//false döndüğü sürece yanıt almaya devam et
        {
            Console.WriteLine("Geçersiz giriş, lütfen '1' veya '2' seçeneklerinden birini seçin!");
            yanit=Console.ReadLine();
        }
            
        } while (yanit=="2");


        }

    // bir girdi ve kontrol edilecek doğru seçeneklerin tutulduğu dizi
    public virtual bool KontrolEt(string girdi, params string[] dogruSecenekler)
    {
    foreach (string secenek in dogruSecenekler)
    {
        if (girdi.Equals(secenek, StringComparison.OrdinalIgnoreCase)/*büyük küçük harfi dikkate almamak için 'OrdinalIgnoreCase'*/)
        //girdi seçenekler içinde mevcut ise true döndür
        {
            return true;
        }
    }
    return false;
    }
}