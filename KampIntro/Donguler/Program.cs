﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { 
            "kurs1","kurs2","kurs3"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");
            foreach (string kurs in kurslar) {

                //dizi dolaş
                Console.WriteLine(kurs);
            
            }

        }
    }
}
