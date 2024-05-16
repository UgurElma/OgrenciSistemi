using System;
using System.Collections.Generic;

class OgrenciYonetimi
{
    public static List<Ogrenci> Ogrenciler = new List<Ogrenci>();

    public OgrenciYonetimi () { }

    public void OgrenciEkleme(Ogrenci ogrenci)
    {
        Ogrenciler.Add(ogrenci);
        Console.WriteLine("Öğrenci Eklendi");
    }
    public float NotOrtalaması()
    {
        float toplam = 0;
        for (int i = 0; i < Ogrenciler.Count; i++)
        {
            toplam += Ogrenciler[i].Notu;
        }
        float ort = toplam / Ogrenciler.Count;
        return ort;
    }

    public void Tumu()
    {
        if (Ogrenciler.Count <= 0)
        {
            Console.WriteLine("Hiçbir öğrenci kaydı bulunamadı!");
        }
        else
        {
            for (int i = 0; i < Ogrenciler.Count; i++)
            {
                Console.WriteLine("Öğrenci adı: {0}  Öğrenci Notu: {1}", Ogrenciler[i].Name, Ogrenciler[i].Notu);
            }
        }
    }
}
