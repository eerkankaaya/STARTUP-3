using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInto
{
    public class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Erkan";
            kurs1.IzlenmeOrani = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "CC";


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "dd";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach ( var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);    
            }

            //kurs diye class oluşturup kendi veri tipini tanımlıyormuş gibi

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
