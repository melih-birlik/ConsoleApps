using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Kemal { 

        public void StartKemal()
    {
        string hammaddecinsi;
            string hammaddetonajı;
            string hammaddeanalizleri;
            Console.Write("Ürünün cinsini Giriniz: ");
            hammaddecinsi = Console.ReadLine();

           Console.Write("Ürünün cinsi: " + hammaddecinsi);
          


            Console.Write("Ürünün tonajını Giriniz: ");
       hammaddetonajı = Console.ReadLine();

        Console.Write("Ürünün tonajı: " + hammaddetonajı +"ton");
   

            Console.Write("Ürüne yapılacak analizleri yanına boşluk koyarak Giriniz: ");
            hammaddeanalizleri = Console.ReadLine();

            Console.Write("Yapılacak analizler: " + hammaddeanalizleri);
     

            


        }
    
    }
    
}
