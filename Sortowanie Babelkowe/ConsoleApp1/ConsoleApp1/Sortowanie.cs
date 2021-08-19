using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sortowanie
    {
        public static void sort(int[] tablica)
        {
            int n = tablica.Length;
            for(int i = 0; i < n - 1; i++)
            {
                int t = tablica[i];
                tablica[i] = tablica[i + 1];
                tablica[i + 1] = t;
            }
            
        }
    }
}
