using System;

internal class Program
{
    static void Main(string[] args)
    {
        OgrenciYonetimi ogrenciYonetimi = new OgrenciYonetimi();
        while(true)
        {
            Console.WriteLine("1 ---> Öğrenci Ekleme       2 ----> Not Ortalaması       3 ----> Tüm Öğrenciler");
            Console.WriteLine("Lütfen yapacağınız işlemi seçin");
            int islem = 0;
            try
            {
                islem = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            { Console.WriteLine(ex.ToString()); }
            Console.Clear();
            if (islem == 1)
            {
                Console.WriteLine(">>>> Öğrenci Ekleme <<<<");
                Console.Write("Öğrenci adini gir:");
                string name = Console.ReadLine();
                Console.Write("Öğrenci notunu gir:");
                float notu = 0;
                try { notu = int.Parse(Console.ReadLine()); }
                catch(Exception ex) { Console.WriteLine(ex.ToString()); }
                Ogrenci ogrenci = new Ogrenci(name, notu);
                ogrenciYonetimi.OgrenciEkleme(ogrenci);
                Console.WriteLine("Geri dönmek için klavyeden bir karaktere basın.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (islem == 2)
            {
                Console.WriteLine(">>>> Sınıf Not Ortalaması <<<<");
                Console.WriteLine("Öğrenci not ortalamaları: " + ogrenciYonetimi.NotOrtalaması());
                Console.WriteLine("Geri dönmek için klavyeden bir karaktere basın.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (islem == 3)
            {
                Console.WriteLine(">>>> Tüm Öğrenciler <<<<");
                ogrenciYonetimi.Tumu();
                Console.WriteLine("Geri dönmek için klavyeden bir karaktere basın.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Uygulama kapatıldı!");
                Console.ReadKey();
                break;
            }
        }
    }
}
