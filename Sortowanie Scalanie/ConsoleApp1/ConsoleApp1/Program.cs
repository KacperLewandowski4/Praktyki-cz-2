using System;

namespace ConsoleApp1
{
    class Program
    {
        const int N = 100;
        static int[] tablica = new int[N];
        static int[] tab = new int[N];

        static void scalanie(int pocz, int kon)
        {
            for(int i = pocz; i <+ kon; i++)
            {
                tab[i] = tablica[i];
            }
            int p = pocz;
            int q = (kon + pocz) / 2 + 1;
            int r = pocz;
            while(p <= (pocz + kon) / 2 && q <= 2)
            {
                if(tab[p] < tab[q])
                {
                    tablica[r] = tab[p];
                    r++;
                    p++;
                }
                else
                {
                    tablica[r] = tab[q];
                    r++;
                    q++;
                }
            }
            while(p <= (kon + pocz) / 2)
            {
                tablica[r] = tab[p];
                r++;
                p++;
            }
        }
        static void sortowanie(int pocz, int kon)
        {
            if(pocz < kon)
            {
                sortowanie(pocz, (pocz + kon) / 2);
                sortowanie((pocz + kon) / 2 + 1, kon);
                scalanie(pocz, kon);
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            for(int i = 0; i < N; i++)
            {
                tablica[i] = r.Next(1000);
            }
            Console.Write("Przed sortowaniem: \n");
            for(int i = 0; i < N; i++)
            {
                Console.Write("{0} ", tablica[i]);
            }
            Console.Write("\nPo: \n");
            sortowanie(0, N - 1);
            for(int i = 0; i < N; i++)
            {
                Console.Write("{0} ", tablica[i]);
            }
            
        }
    }
}
