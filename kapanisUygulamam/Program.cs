using System;
using System.Collections.Generic;

public class Araba
{
    public DateTime UretimTarihi { get; set; }
    public string SeriNo { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            string giris;

            // 1. Kullanıcıya üretim isteğini sor
            do
            {
                Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
                giris = Console.ReadLine().Trim().ToLower();

                if (giris != "e" && giris != "h")
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sadece E veya H giriniz.");
                }

            } while (giris != "e" && giris != "h");

            if (giris == "h")
                break;

            // 2. Yeni araba nesnesi oluştur
            Araba araba = new Araba();
            araba.UretimTarihi = DateTime.Now;

            Console.Write("Seri No: ");
            araba.SeriNo = Console.ReadLine();

            Console.Write("Marka: ");
            araba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            araba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            araba.Renk = Console.ReadLine();

        KapiGiris:
            Console.Write("Kapı Sayısı: ");
            try
            {
                araba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hatalı giriş! Lütfen sayısal bir değer giriniz.");
                goto KapiGiris;
            }

            // 5. Araba listeye ekleniyor
            arabalar.Add(araba);
            Console.WriteLine("✅ Araba başarıyla üretildi!\n");
        }

        // 6. Program sonunda listeyi yazdır
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri No: {araba.SeriNo}, Marka: {araba.Marka}");
        }

        Console.WriteLine("\nProgram sonlandı. 👋");
    }
}
