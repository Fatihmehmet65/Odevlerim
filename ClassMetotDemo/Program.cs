using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.MusteriAdi = "Fatih";
            musteri1.Id = 1;
            musteri1.Gorevi = "Mühendis";
            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Mehmet";
            musteri2.Id = 2;
            musteri2.Gorevi = "Esnaf";

            Musteri[] musteriler = new Musteri[]
                {musteri1,musteri2};





            MusteriManager musteri=new MusteriManager();
            musteri.MusteriEkle(musteri1);
            musteri.MusteriListeleme(musteriler);
            musteri.MusteriSil(musteri2);

        }
    }
}
