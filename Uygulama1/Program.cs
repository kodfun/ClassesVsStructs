Nokta n1 = new Nokta();
n1.X = 3;
n1.Y = 4;
Console.WriteLine(n1.Ozet());

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
