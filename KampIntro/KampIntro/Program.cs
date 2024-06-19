using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety
            // değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;
            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirisYapmismi == true) 
            {
                Console.WriteLine("Kullanıcı Ayarlar");
            }
            else
            {
                Console.WriteLine("Giris Yap");
            }




        }
    }
}
