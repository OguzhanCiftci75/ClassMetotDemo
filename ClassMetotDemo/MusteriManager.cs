using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Isim + "-" + musteri.Soyisim + " ----->  " + "İsimli Müşteri Listelendi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }
                           
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Isim + "-" + musteri.Soyisim + " ----->  " + "İsimli Müşteri Eklendi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }
            
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine(musteri.Isim + "-" + musteri.Soyisim + " ----->  " + "İsimli Müşteri Silindi");
            Console.WriteLine("TC: " + musteri.TC);
            Console.WriteLine("Doğum Yeri: " + musteri.DogumYeri);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNumarasi);
            Console.WriteLine("\n");
        }  
    
    
    
    
    
    
    
    
    }
}
