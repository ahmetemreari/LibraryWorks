using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LibraryWorks
{
    public class BooksData
    {
        private int _SayfaSayisi;
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }

        public string YayinEvi { get; set; }

        public DateTime YayinTarihi { get; set; }

        public int SayfaSayisi
        {
            get { return _SayfaSayisi; }
            set
            {
                if (value < 0)
                {
                    _SayfaSayisi = 0;
                    Console.WriteLine("Sayfa sayısı 0'dan küçük olamaz.");
                }
                else
                {
                    _SayfaSayisi = value;
                }
            }
        }
//default constructor
        public BooksData()
        {
            KitapAdi = "Aylin";
            Yazar = "Ayse Kulin";
            SayfaSayisi = 398;
            YayinEvi = "Ramiz Kitabevi";
            YayinTarihi = DateTime.Now;

    }
    //parameterized constructor
        public BooksData(string kitapAdi, string yazar, int sayfaSayisi, string yayinEvi)
        {
            this.KitapAdi = kitapAdi;
            this.Yazar = yazar;
            this.SayfaSayisi = sayfaSayisi;
            this.YayinEvi = yayinEvi;
            this.YayinTarihi = DateTime.Now.Date;
        }

        public void KitapBilgileri()
        {
            string date = YayinTarihi.ToString("dd/MM/yyyy");
            Console.WriteLine($"Kitap Adı: {KitapAdi} Yazar : {Yazar} Sayfa Sayısı : {SayfaSayisi} Yayın Evi : {YayinEvi} Yayın Tarihi : {date}");
        }
    }
}