using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Isim = "Ahmet";
            musteri1.Soyisim = "Parlak";
            musteri1.TC = 13957392050;
            musteri1.DogumYeri = "Ankara";
            musteri1.TelefonNumarasi = 5394782341;

            Musteri musteri2 = new Musteri();
            musteri2.Isim = "Kenan";
            musteri2.Soyisim = "Kurt";
            musteri2.TC = 16987246153;
            musteri2.DogumYeri = "Samsun";
            musteri2.TelefonNumarasi = 5355917955;

            Musteri musteri3 = new Musteri();
            musteri3.Isim = "Gamze";
            musteri3.Soyisim = "Yildiz";
            musteri3.TC = 47891766529;
            musteri3.DogumYeri = "Sivas";
            musteri3.TelefonNumarasi = 527963213;

            Musteri musteri4 = new Musteri();
            musteri4.Isim = "Irmak";
            musteri4.Soyisim = "Turk";
            musteri4.TC = 85326974155;
            musteri4.DogumYeri = "Bursa";
            musteri4.TelefonNumarasi = 5405858744;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            // Listeleme 
            Console.WriteLine("Müşteri Listesi:\n");
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriListele(musteri4);

            // Ekleme
            Console.WriteLine("Müşteri Ekleme:\n");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);

            // Silme
            Console.WriteLine("Müşteri Silindi:\n");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);







            Console.ReadLine();
        }
    }
}
