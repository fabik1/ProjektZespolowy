using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BibliotekaMatematyczna bm1 = new BibliotekaMatematyczna();
            Console.WriteLine($"NWD: {bm1.Euklides(18,24)}");

            int[] tab = { 2, 3, 4, 5, 1, 2, 3, 4, 5, 5, };
            bm1.BubleSort( tab );
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine($"{tab[i]}, ");
            }

            Console.WriteLine($"Liczba minimalna: {bm1.Min(tab)}");
            Console.WriteLine($"Liczba minimalna: {bm1.Max(tab)}");

            Console.WriteLine($"Czy 7 to liczba pierwsza: {bm1.CzyPierwsza(7)}");
            Console.WriteLine($"Potęgowanie liczby 2^3: {bm1.potęgowanie(2, 3)}");
        }
    }
}
