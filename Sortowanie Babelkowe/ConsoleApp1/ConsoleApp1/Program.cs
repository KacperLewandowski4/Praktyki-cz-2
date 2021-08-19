using System;

namespace ConsoleApp1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int[] liczby = {32, 54, 2, 43, 4, 6, 32, 9, 12, 6, 32, 654, 43, 432, 321, 65, 76, 654, 32, 12, 43, 44, 56, 98, 90, 45, 24 };
            Console.WriteLine("Przed sortowaniem: ");
            for(int i = 0; i < liczby.Length; i++)
            {
                Console.Write(Convert.ToString(liczby[i]) + " ");
            }
            sort(liczby);
            
            Console.Write("\nPo: \n");
            for(int i = 0; i < liczby.Length; i++)
            {
                Console.Write(Convert.ToString(liczby[i]) + " ");
            }
            
        }
        public static void sort(int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int t = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = t;
                    }
                }
                n--;
            }
            while (n > 1);
        }
    }
}
