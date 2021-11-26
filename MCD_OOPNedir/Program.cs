using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç Sınıfı Listeleme
            Arac araba1 = new Arac("bmw","x5",2010,56000);
            araba1.AlisFiyat = 28000;
            araba1.SatisFiyat = 32000;
            araba1.MaxIndirimTutar = 1500;
            //araba1.Fiyat = Kapsülleme konusu
            araba1.FiyatAta(31000);
            araba1.BilgileriGörüntüle();


            #endregion 
            Console.ReadKey();
        }
    }
}
