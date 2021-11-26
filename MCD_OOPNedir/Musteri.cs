using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Musteri
    {
        /*TCKimlik Numarası
         * İsim
         * Soyisim
         * Cinsiyet
         * 
         */

        //Property Özellikler
        public string TcNo;
        public string İsim;
        public string Soyad;
        public int Cinsiyet; //717770001 : Bay - 717770002 : Bayan

        //Yapıcı Metot Constructor
        public Musteri()
        { }
        
        public Musteri (string _tcKimlikNo)
        {
            TcNo = _tcKimlikNo;
        }

        public Musteri(string _tcKimlikNo ,string _isim)
        {
            TcNo = _tcKimlikNo;
            İsim = _isim;
        }

        public Musteri(string _tcKimlikNo, string _isim,string _soyad)
        {
            TcNo = _tcKimlikNo;
            İsim = _isim;
            Soyad = _soyad;
        }

        public Musteri(string _tcKimlikNo, string _isim, string _soyad,int _cinsiyet)
        {
            TcNo = _tcKimlikNo;
            İsim = _isim;
            Soyad = _soyad;
            Cinsiyet = _cinsiyet;
        }

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TcNo);
            return kontrol  ;
        }

        private bool MusteriKontrolDatabase(string tcKimlikNumarasi)
        {
            //database gidilir müşterinin tc kimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır...
            return true;
        }

           
    }
}
