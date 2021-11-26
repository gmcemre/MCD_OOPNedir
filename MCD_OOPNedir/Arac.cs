using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal  Km;                          //    <=  Property'ler.Yani özellikler (Durumlar)
        public int YakitTip;
        public int VitesTip;                         // Private olarak girersek => get ve set mantığını işletmemiz gerekir...
        public decimal  AlisFiyat;
        public decimal SatisFiyat;
        public decimal  MaxIndirimTutar;
        public decimal  Fiyat;
      
        public Arac()    //Boş bir constractor ekledik.Bu sınıfı kullanılabilir hale getirmek için tanımlıyoruz...Çatlamaması için...
        { }              //Sınıfın ismiyle aynı olmak zorunda.

        public Arac (string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }

        public Arac (string _marka,string _model,int _modelYil)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
        }

        public Arac(string _marka, string _model, int _modelYil,decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
            Km = _km;
        }

        //Sağ tıkla =>  Quick Actions and Refactorings + Generate Constructor
        //public Arac(string marka, string model, int modelYil, decimal km, int yakitTip) : this(marka, model, modelYil, km)
        //{
        //    YakitTip = yakitTip;
        //}

        public void BilgileriGörüntüle()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yıl {2}",Marka ,Model ,ModelYil);
        }
        
        public void FiyatAta (decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat < fiyatHesap )
            {
                Console.WriteLine("Geçersiz fiyat girişi.");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat Güncellendi");
            }
        }

        

    }
}
