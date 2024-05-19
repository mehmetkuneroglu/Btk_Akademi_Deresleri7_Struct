using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Channels;

public partial class Program
{   
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
        // deault constructor
        public Nokta(int x, int y)
        {
            X = x ;
            Y = y ;
        }
        // Yapıya yeni üye -> Metot ekliyoruz
        public void SetOrigin()
        {
            this.X=0 ; 
            this.Y=0 ;
        }
        // x ve y nin yerini değiştir
        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici;
        }
    }
    
    private static void Main(string[] args)
    {
        
        var n1= new Nokta(3,4);
        Console.WriteLine($"n1:  {n1}");
        n1.Degistir(); //yer değiştirme işlemi yaptı ve aşağıda tekrar çağırdık
        Console.WriteLine($"n1:  {n1}");

        // struct yapılar değer tiplidir. bunu aşağıdaki örnekle görebiliriz
        var n2 = n1;
        Console.WriteLine($"n2:  {n2}");
        n2.X = -1 * n2.X;
        Console.WriteLine("Değer tipli yapılarda birinde yapılan değişiklik bir diğerini etkilemez.");
        Console.WriteLine($"n1:  {n1}");
        Console.WriteLine($"n2:  {n2}");

        Console.ReadKey();

        structOrnegi();
    }
    // Ogrenci.cs dosyası burada struct yapısı olarak tanımlandı
    // daha sonra yapılandırma aracıyla Ogrenci.cs ye taşı metodu kullanılarak ayrı bir dosya 
    // olarak kaydedildi
    private static void structOrnegi()
    {
        // struct yapının kullanımı
        //Değer atama
        Ogrenci ogr1 = new Ogrenci();
        ogr1.Numara = 1;
        ogr1.Adi = "Mehmet";
        ogr1.Soyadi = "Kuneroğlu";
        ogr1.Cinsiyet = true;

        //Değerlere Ulaşma
        Console.WriteLine($"{ogr1.Numara} " +
            $"{ogr1.Adi} " +
            $"{ogr1.Soyadi} " +
            $"{ogr1.Cinsiyet}"
            );

        //Alternattif Kullanım 1
        Ogrenci ogr2 = new Ogrenci()
        {
            Numara = 2,
            Adi = "Ayşe",
            Soyadi = "Kuneroglu",
            Cinsiyet = false

        };
        //Değerlere Ulaşma
        Console.WriteLine($"{ogr2.Numara} " +
            $"{ogr2.Adi} " +
            $"{ogr2.Soyadi} " +
            $"{ogr2.Cinsiyet}"
            );

        //AlternATİF Kullanım 2
        var ogr3 = new Ogrenci(3, "Zeynep", "Kuneroğlu", false); //yapıcı metot kullanım örneği
                                                                 //Değerlere Ulaşım
        Console.WriteLine($"{ogr3.Numara} " +
           $"{ogr3.Adi} " +
           $"{ogr3.Soyadi} " +
           $"{ogr3.Cinsiyet}"
           );
        Console.WriteLine();
        Console.WriteLine("Override işleminden sonra yazılan kodlar");
        Console.WriteLine();
        // Ezme işleminden sonra yazılan kodlar
        Console.WriteLine(ogr1);
        Console.WriteLine(ogr2);
        Console.WriteLine(ogr3);
        Console.WriteLine();

        // struct yapısının List ile kullanmak
        var Ogrenciler = new List<Ogrenci>()
        {
           new Ogrenci(4, "Mehmet", "Kuneroğlu", true),
           new Ogrenci(5, "Ayşe", "Kuneroğlu", false),
           new Ogrenci(6, "Zeynep", "Kuneroğlu", false),
        };
        //foreach (var item in Ogrenciler)
        //{
        //    Console.WriteLine(item);
        //}

        // Liste şeklinde tanımladıktan sonra kullanım
        Console.WriteLine("Liste şeklinde tanuımladıktan sonra kullanım");
        Ogrenciler.ForEach(i => Console.WriteLine(i));
    }
}