using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var array = new int[100];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1000);
            }
            Console.Write("Przed sortowaniem: \n");
            Console.Write(string.Join(" ", array));
            Quicksort(array, 0, array.Length - 1);
            Console.Write("\nPo: \n");
            Console.Write(string.Join(" ", array));
        }
        public static void Quicksort(int[] array,int lewo,int prawo)
        {
            var i = lewo;
            var j = prawo;
            var p = array[(prawo + lewo) / 2];
            while(i < j)
            {
                while (array[i] < p) i++;
                while (array[j] > p) j--;
                if(i <= j)
                {
                    var t = array[i];
                    array[i++] = array[j];
                    array[j--] = t;
                }
            }
            if (lewo < j) Quicksort(array, lewo, j);
            if (i < prawo) Quicksort(array, i, prawo);
        }
    }
}
