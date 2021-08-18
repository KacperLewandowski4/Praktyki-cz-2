using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char text;
            string text2;

            //text = char.Parse(Console.ReadLine()); // z tym da sie tylko 1 litere

            //text2 = Convert.ToString(text); // -||-
            text2 = Console.ReadLine();

            string textdokodowania = kodowanie(text2);

            Console.WriteLine(textdokodowania);

            Console.ReadLine();
        }
        static public string kodowanie(string kod)
        {
            byte[] bit = System.Text.ASCIIEncoding.ASCII.GetBytes(kod);

            string zwroc = System.Convert.ToBase64String(bit);

            return zwroc;
        }
    }
}
