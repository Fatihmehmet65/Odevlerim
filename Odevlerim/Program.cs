using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevlerim
{
    internal class Program
    {
        static void Main(string[] args)
        {
             bool deneme= true;
            //if (deneme == false) {

            //    Console.WriteLine("yanlıştır.");
            //}
            //else

            //{ Console.WriteLine("doğrudur"); }
            //int sayi = 25;
            //string sonuc = (deneme==true) ? "Doğrudur" : "Yada yanlıştır";
            //Console.WriteLine(sonuc);
            //Console.Write("x sayısını gir: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y sayısını gir: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //string sonuc1;

            //sonuc1 = (x > y) ? "x değeri y den büyüktür." : (x < y) ? "x değeri y den küçüktür." : "x ve y değerleri eşittir.";
            //Console.WriteLine(sonuc1);

            //Console.ReadLine();
            Urunler urunler = new Urunler();
            urunler.UrunId = 1;
            urunler.Stok = 17;
            urunler.UrunAdi = "Çikolata";
            Urunler urunler2 = new Urunler();
            urunler2.UrunId = 12;
            urunler2.Stok = 170;
            urunler2.UrunAdi = "Çikolata1";
            Urunler[] urunlers = new Urunler[] { urunler, urunler2 };

            foreach (var elamans in urunlers)
            {
                Console.WriteLine("Urün ADI: "+ elamans.UrunAdi+" UrunId: "+ elamans.UrunId+" Stok: "+ elamans.Stok);
                Console.WriteLine("********************************************");
            }
            int i= 0;
            while (i<urunlers.Length)
            {
                Console.WriteLine("ürünadi: " + urunlers[i].UrunAdi +" UrunId: " + urunlers[i].UrunId +" "+"Urun Stok:" + urunlers[i].Stok); 
                i++;
            }
            Console.WriteLine("FOR için Deneme **********************");

            for (int i1 = 0; i1 < urunlers.Length; i1++)
            {
                Console.WriteLine("UrunAdi:" + urunlers[i1].UrunAdi + " UrunId: " + urunlers[i1].UrunId + "Urun Stok:" + urunlers[i1].Stok);
                Console.WriteLine("                                                         ");
            }

            Urunler urunler1 = new Urunler();
            urunler1.Add4(1,2,3,4,5,5,6,7,8,9,10);
            Console.WriteLine(urunler1.Add4(1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10) );
        }
    }
}
