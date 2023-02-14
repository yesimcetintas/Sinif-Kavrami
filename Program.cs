
Calisan calisan1 = new Calisan("Ayşe","Kara",234567,"İK");

// calisan1.Ad = "Ayşe";
// calisan1.Soyad = "Kara";
// calisan1.No = 234567;
// calisan1.Departman = "İK";

calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan("Deniz", "Arda",2344556, "İK");

// calisan2.Ad = "Deniz";
// calisan2.Soyad = "Arda";
// calisan2.No = 2344556;
// calisan2.Departman = "İK";

calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan("Yeşim", "Çetintaş");
calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman){
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad){
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public void CalisanBilgileri(){
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyad:{0}", Soyad);
        Console.WriteLine("Çalışanın No:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:", Departman);
    }
}
