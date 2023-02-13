
Calisan calisan1 = new Calisan();

calisan1.Ad = "Ayşe";
calisan1.Soyad = "Kara";
calisan1.No = 234567;
calisan1.Departman = "İK";

calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();

calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 2344556;
calisan2.Departman = "İK";

calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri(){
        Console.WriteLine("Çalışanın Adı:{0}",Ad);
        Console.WriteLine("Çalışanın Soyad:{0}", Soyad);
        Console.WriteLine("Çalışanın No:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:", Departman);
    }
}
