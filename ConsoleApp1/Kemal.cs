﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Kemal {

        public void StartKemal()
        {
            double val = 0;
            string sayi = "";


            Console.Write("Ürünün tonajını giriniz: ");


            ConsoleKeyInfo karakter;
            do
            {
                karakter = Console.ReadKey(true);
                if (karakter.Key != ConsoleKey.Backspace)
                {
                    bool kontrol = double.TryParse(karakter.KeyChar.ToString(), out val);
                    if (kontrol)
                    {
                        sayi += karakter.KeyChar;
                        Console.Write(karakter.KeyChar);
                    }
                }
                else

                {
                    if (karakter.Key == ConsoleKey.Backspace && sayi.Length > 0)
                    {
                        sayi = sayi.Substring(0, (sayi.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (karakter.Key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine("Ürünün tonajı : " + sayi + "ton");
       
            Console.WriteLine("Ürünün cinsini seçiniz");
            Console.WriteLine("Ürün Seçenekleri");
            Console.WriteLine("1-Bilye Kekik");
            Console.WriteLine("2-Sivri Kekik");
            Console.WriteLine("3-Kimyon");
            Console.WriteLine("4-Rezene");
            Console.WriteLine("5-Ada Çayı");
            Console.WriteLine("6-Mavi Haşhaş");
            Console.WriteLine("7-Anason");
            Console.WriteLine("8-Biberiye");
            Console.WriteLine("9- Çıkış");

            int urununcinsi = Convert.ToInt32(Console.ReadLine());
            switch (urununcinsi)
            {
                case 1 :
                    Console.WriteLine("Bilye Kekik");
                    break;
                case 2 :
                    Console.WriteLine("Sivri Kekik");
                    break;

                case 3:
                    Console.WriteLine("Kimyon");
                    break;

                case 4:
                    Console.WriteLine("Rezene");
                    break;
                case 5:
                    Console.WriteLine("Adaçayı");
                    break;
                case 6:
                    Console.WriteLine("Mavi Haşhaş");
                    break;
                case 7:
                    Console.WriteLine("Anason");
                    break;
                case 8:
                    Console.WriteLine("Biberiye");
                    break;
                case 9:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Geçersiz bir değer girdiniz.");
                    break;
            }

            Console.WriteLine("Ürüne yapılacak analizleri seçiniz.");
            Console.WriteLine("1-a");
            Console.WriteLine("2-b");
            Console.WriteLine("3-c");
            Console.WriteLine("4-d");

            int analiz = Convert.ToInt32(Console.ReadLine());

            switch (analiz)
            {
                case 1:
                    Console.WriteLine("a");
                    break;
                case 2:
                    Console.WriteLine("b");
                    break;
                case 3
                      :
                    Console.WriteLine("c");
                    break;


            }

        }

    }

}





















































































































































































































































































































































































































































































































































































































































































































































































































































































