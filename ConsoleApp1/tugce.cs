using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Tugce
    {
        public void StartTugce()
        {
            string HammaddeTonaj;
            string sayi = "";
            while (true)
            {
                Console.WriteLine("------İşlemler ---------");
                Console.WriteLine("A-Analizler");
                Console.WriteLine("C-Cinsi");
                Console.WriteLine("Ç-Çıkış");

                Console.Write("Seçiminiz:");
                string menuSecim = Console.ReadLine().ToUpper();
                if (menuSecim == "A")
                {
                    while (true)
                    {
                        Console.WriteLine("------Analizler ---------");
                        Console.WriteLine("1-A");
                        Console.WriteLine("2-B");
                        Console.WriteLine("3-C");
                        Console.WriteLine("9-Üst Menüye Dön");
                        Console.WriteLine("0-Çıkış");
                        Console.Write("Seçiminiz:");
                        string secim = Console.ReadLine();

                        if (secim == "9")
                            break;
                        else if (secim == "0")
                            Environment.Exit(0);
                    }
                }
                else if (menuSecim == "C")
                {
                    while (true)
                    {
                        Console.WriteLine("------Cinsi ---------");
                        Console.WriteLine("1-Bilye Kekik");
                        Console.WriteLine("2-Sivri Kekik");
                        Console.WriteLine("3-Kimyon");
                        Console.WriteLine("4-Rezene");
                        Console.WriteLine("5-Ada Çayı");
                        Console.WriteLine("6-Mavi Haşhaş");
                        Console.WriteLine("7-Anason");
                        Console.WriteLine("8-Biberiye");
                        Console.WriteLine("9-Üst Menüye Dön");
                        Console.WriteLine("0-Çıkış");
                        Console.Write("Seçiminiz:");
                    }
                }

                else
                    Console.WriteLine("Yanlış Seçim");
            }
        
            Console.WriteLine("Hammadde Tonajını giriniz: ");
            ConsoleKeyInfo karakter;
            do
            {
                karakter = Console.ReadKey(true);

                if (karakter.Key != ConsoleKey.Backspace)
                {
                    double val = 0;

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
        }
        
          
    }

}

