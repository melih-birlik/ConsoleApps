﻿using System;
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
                        if (secim[0] == '1')
                        {
                            Console.WriteLine("A");
                        }
                        else if (secim[0] == '2')
                        {
                            Console.WriteLine("B");
                        }
                        else if (secim[0] == '3')
                        {
                            Console.WriteLine("C");
                        }
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
                        string secim = Console.ReadLine();
                        if (secim[0] == '1')
                        {
                            Console.WriteLine("Bilye Kekik");
                        }
                        else if (secim[0] == '2')
                        {
                            Console.WriteLine("Sivri Kekik");
                        }
                        else if (secim[0] == '3')
                        {
                            Console.WriteLine("Kimyon");
                        }
                        else if (secim[0] == '4')
                        {
                            Console.WriteLine("Rezene");
                        }
                        else if (secim[0] == '5')
                        {
                            Console.WriteLine("Ada Çayı");
                        }
                        else if (secim[0] == '6')
                        {
                            Console.WriteLine("Mavi Haşhaş");
                        }
                        else if (secim[0] == '7')
                        {
                            Console.WriteLine("Anason");
                        }
                        else if (secim[0] == '8')
                        {
                            Console.WriteLine("Biberiye");
                        }
                        if (secim == "9")
                            break;
                        else if (secim == "0")
                            Environment.Exit(0);
                    }

                }

                else if (menuSecim == "Ç")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim");
                }
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
                    if (sayi.Length > 6)
                    {
                        Console.WriteLine("Tonaj en fazla 6 haneli olmalıdır. Lütfen tekrar giriniz:");
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
    




                
        
        

    



    





    



    