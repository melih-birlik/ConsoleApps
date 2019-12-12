using System;
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
            Console.ReadKey();




            Console.WriteLine("Ürünün cinsini seçiniz");
            int urununcinsi = Convert.ToInt32(Console.ReadLine());

            switch (urununcinsi)
            {
                case 1 :
                    Console.WriteLine("a");
                    break;
                case 2 :
                    Console.WriteLine("b");
                    break;

                case 3:
                    Console.WriteLine("c");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir değer girdiniz.");
                    break;
            }

            Console.Read();


        }

    }
    
}
