using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevlerim
{
    internal class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int Stok { get; set; }

       //3 den falza değer istenirse params T[] item ---> şeklinde ayarlanır...
        public int Add4(params int[] number)
        {
            return number.Sum();
        }
    }
}
