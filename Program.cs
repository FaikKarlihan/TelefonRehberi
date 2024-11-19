using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


do
{
Console.Clear();

Console.WriteLine("Telefon Rehberine Hoşgeldiniz...Lütfen Yapmak İstediğiniz İşlemi Seçin.");
Console.WriteLine("**************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncellemek");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");
Console.WriteLine("(0) Çıkış");
string yanit = Console.ReadLine();

while (!yanitkontrol(yanit,"1","2","3","4","5","0"))
{
    Console.WriteLine("Geçersiz giriş, lütfen sunulan seçeneklerden birini seçin!");
    yanit = Console.ReadLine();
}


if (yanit=="1")
{
    NumaraEkleme ekleObj = new();
    ekleObj.Ekle();
}
if (yanit=="2")
{
    NumaraSilme silObj = new();
    silObj.Sil();
}
if (yanit=="3")
{
    NumaraGüncelleme güncelleObj = new();
    güncelleObj.Güncelle();
}
if (yanit=="4")
{
    RehberListeleme listeleObj = new();
    listeleObj.Listele();
}
if (yanit=="5")
{
    RehberdeArama AraObj = new();
    AraObj.Ara();
}
if (yanit=="0")
{
    Environment.Exit(0);
}




} while (true);

static bool yanitkontrol(string girdi, params string[] cevaplar )// bir girdi ve kontrol edilecek doğru cevapların tutulduğu dizi
{
    foreach (var yanit in cevaplar)
    {
        if (girdi.Equals(yanit, StringComparison.OrdinalIgnoreCase)/*büyük küçük harfi dikkate almamak için 'OrdinalIgnoreCase'*/)
        //girdi seçenekler içinde mevcut ise true döndür
        {
            return true;
        }
    }
    return false;
}
