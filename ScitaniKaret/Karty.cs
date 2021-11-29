using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScitaniKaret
{
    class Karty
    {

        public void SectiKarty()
        {
            List<int> pocetKaret = new List<int>();
            int pocet;
            int i = 1;
            Console.WriteLine("-----Vítejte ve sčítači karet-----");
            Console.WriteLine("Zadávejte počty karet v jednotlivých dávkách.");
            Console.WriteLine("Pokud zadáte počet 0, tak se sečtou všechny karty a bude vypsán jejich součet.");

            do
            {

                
                Console.Write("Zadejte {0}. počet karet: ", i++);
                pocet = int.Parse(Console.ReadLine());

                if ((pocet != 0) && ( pocet > 0))
                {
                    pocetKaret.Add(pocet);
                }
                else if (pocet == 0)
                { 
                        Console.WriteLine("Byl zadát počet 0, aplikace sečte všechny karty a vypíše součet.");
                }
                else if (pocet < 0)
                {
                    Console.WriteLine("Byla zadána záporná hodnosta, aplikace bude ukončena.");
                }

            } while ((pocet != 0) && (pocet > 0));



                if (pocetKaret.Sum() == 0)
                {
                    Console.WriteLine("V dávkách nebyla ani jedna karta");
                }
                else
                {
                    Console.WriteLine("Celkový počet karet je: " + pocetKaret.Sum());
                    Console.Write("V dávkách byly tyto hodnoty: {0}", string.Join(", ", pocetKaret));
                }
        }
        
    }
}
