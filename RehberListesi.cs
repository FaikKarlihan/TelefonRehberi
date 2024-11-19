// Sabit Rehber

public class Kisi{
    public string Isim {get; set;}
    public string Soyisim {get; set;}
    public string Numara {get; set;}
}
public class Rehber{
public static List<Kisi> Rehberim { get; set;} = new List<Kisi>(){

    new Kisi { Isim = "Faik", Soyisim = "Karlıhan", Numara = "5442568911" },
    new Kisi { Isim = "Gökhan", Soyisim = "Usan", Numara = "5056984786" },
    new Kisi { Isim = "Umut", Soyisim = "Doğan", Numara = "5453691257" },
    new Kisi { Isim = "Mert Can", Soyisim = "Yılmaz", Numara = "5305893210" },
    new Kisi { Isim = "Abdülkadir", Soyisim = "Keskin", Numara = "5428793120" }
};

}