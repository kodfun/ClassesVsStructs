//Nokta sınıfını kullanarak [3,4] koordinatlarında bir nokta değişkeni n1 tanımla
//n2 adlı başka bir nokta değişkeni oluştur ve n1’i n2’ye ata
//İkisinin bir biriyle aynı nokta olduğunu göster
//Nokta sınıfını struct haline çevir ve bu sefer de n1 ve n2’nin bir birinden bağımsız değerler haline geldiğini göster
Nokta n1 = new Nokta() { X = 3, Y = 4 };
Nokta n2 = n1;
n1.X = 77;
Console.WriteLine(n2.X);

Console.ReadKey();

// class yerine struct yaz ve tekrar çalıştır
public class Nokta
{
    public int X { get; set; }

    public int Y { get; set; }

    public string Ozet()
    {
        return $"X={X} Y={Y}";
    }
}