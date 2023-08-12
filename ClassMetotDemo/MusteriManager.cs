using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {


        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "Adlı kişi Eklenmiştir");


        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "Adlı Kişi Silinmiştir");
        }
        public void MusteriListeleme(Musteri[] musteri)
        {
            foreach (Musteri m in musteri)
            {
                Console.WriteLine("MusteriAdi :" + m.MusteriAdi + "MusteriId: " + m.Id + " Musteri Görevi: " + m.Gorevi);
            }
        }
    }
 }
