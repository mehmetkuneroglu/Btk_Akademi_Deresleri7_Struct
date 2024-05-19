public partial class Program
{
    public struct Ogrenci  // struct yapı tanımlama
    {
        // BU  kısım sonradan değiştirimdi
        //yapılandırıcı metot haline getirildi - constructor
        //yapılandırıcı veya yapıcı metot struct ismiyle aynı olan metottur
        //yapıcı metotlar otomatik olarak çalıştırılırlar.
        //Bu yapının son haliyle ilgili kullnım örneği, Alternatif Kullanım 2 de yer aldı
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet) 
        {                                                                    
            Numara = numara;                                                 
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //Geçersiz kılmak- Ezmek- ovverride etmek
        // kod yazımını kısa ve sade hale getirmek için çok kullanışlı bir yapı
        public override string ToString()
        {
            return $"{Numara,-5}" +
                $"{Adi,-10}" +
                $"{Soyadi,-15}" +
                string.Format("{0,-10}", Cinsiyet == true ? "Bay" : "Bayan");
                ;
        }
    }
}