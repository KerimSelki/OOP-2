using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adı = "Engin";
            musteri1.Soyadı = "Demiroğ";
            musteri1.TcNo = "12345678910";


            // Tüzel Müşteri
            TüzelMüşteri musteri2 = new TüzelMüşteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            Musteri musteri3 = new GerçekMusteri();
            Musteri musteri4 = new TüzelMüşteri();
        }
    }
}
