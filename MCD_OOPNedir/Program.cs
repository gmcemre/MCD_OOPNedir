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
            Console.WriteLine("********************************************");
            #endregion

            #region 
            Musteri M1 = new Musteri("122544013254","Murat");
            M1.TcNo = "1225440152";
            M1.İsim = "Cengiz";
            M1.Soyad = "Kara";
            M1.Cinsiyet = 717770001;
            Musteri M2 = M1;

            M2.İsim = "Murat";
            M2.TcNo = "12254401325";

            //bool musteriKontrol = M2.MusteriKontrol();
            //Console.WriteLine(musteriKontrol );

            //M2 = null;
            //M1 = null;

            string isim = M2.İsim;


            Console.WriteLine(isim );
            Console.WriteLine("********************************************");
            #endregion 

            //Classlardan nesne bu şekilde new kelimesi ile türetilir
            //So , a class is a template for objects , and an object is an instanse of a class.

            Fruit meyve1 = new Fruit();
            meyve1.FruitName = "Bu Bir Elmadır";
            meyve1.MeyveRengi  = "Kırmızı";
            meyve1.olusturulmaTarihi  = DateTime .Now ;

            Console.WriteLine(meyve1 .FruitName );
            Console.WriteLine(meyve1 .MeyveRengi  );
            Console.WriteLine(meyve1.olusturulmaTarihi);
            Console.WriteLine("********************************************");

            Fruit meyve2 = new Fruit();
            meyve2.FruitName = "Bu Bir Çilektir";
            meyve2.MeyveRengi = "Pembe";
            meyve2.olusturulmaTarihi = DateTime.Now;

            Console.WriteLine(meyve2.FruitName);
            Console.WriteLine(meyve2.MeyveRengi);
            Console.WriteLine(meyve2.olusturulmaTarihi);
            Console.WriteLine("********************************************");

            Fruit meyve3 = new Fruit();
            
            Console.WriteLine(meyve3.FruitName);
            Console.WriteLine(meyve3.MeyveRengi);
            Console.WriteLine(meyve3.olusturulmaTarihi);
            Console.WriteLine("********************************************");

            Console.ReadKey();
        }
    }
}
