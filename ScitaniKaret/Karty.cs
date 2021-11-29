using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniKaret
{
    class Karty
    {
        
        public void PocetKaret()
        {
            Console.WriteLine("Zadejte počet dávek: ");
            int pocetDavek = int.Parse(Console.ReadLine());
            int[] pocetKaret = new int[pocetDavek];
            Console.WriteLine("Zadejte počet karet: ");
            for (int i = 0; i < pocetDavek; i++)
                {
                    pocetKaret[i] = int.Parse(Console.ReadLine());
                }
            int suma = pocetKaret.Sum();
            Console.WriteLine("Celkový počet karet je: " + suma);
            


        }

    }
}
