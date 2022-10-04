
using ClassMetotDemo;


        Musteri musteri1 = new Musteri();
        musteri1.Id = 1;
        musteri1.Adi = "Semih";
        musteri1.Soyadi = "Sayar";

        Musteri musteri2 = new Musteri();
        musteri2.Id = 2;
        musteri2.Adi = "Engin";
        musteri2.Soyadi = "Demiroğ";


        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri1);

        Console.WriteLine("-------------------");

        musteriManager.Sil(musteri1);
        musteriManager.Sil(musteri2);

        Console.WriteLine("-------------------");
        Console.WriteLine("Müşteri Listeleme");

        musteriManager.Liste(musteri1);
        musteriManager.Liste(musteri2);



