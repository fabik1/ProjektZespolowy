using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZespolowy
{
    public class BibliotekaMatematyczna
    {
        public int Euklides(int a, int b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public int[] BubleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }

            return tab;
        }

        public int Min(int[] tab)
        {
            int min = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (min > tab[i])
                {
                    min = tab[i];
                }
            }

            return min;
        }
        public int Max(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (max < tab[i])
                {
                    max = tab[i];
                }
            }
            return max;
        }

        public int[] InsertSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int min = tab[i];
                int minIndex = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < min)
                    {
                        min = tab[j];
                        minIndex = j;
                    }
                }
                tab[minIndex] = tab[i];
                tab[i] = min;
            }
            return tab;
        }
        bool CzyPierwsza(int liczba)
        {
            bool wynik = false;
            int dzielniki = 0;
            for (int i = 1; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    dzielniki++;
                }
            }
            if (dzielniki == 2)
            {
                wynik = true;
            }
            else if (dzielniki > 2)
            {
                wynik = false;
            }
            return wynik;
        }
    }
}
