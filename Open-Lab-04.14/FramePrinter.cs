using System;
using System.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            var lword = strings.OrderByDescending(s => s.Length).First().Length;
            for (var a = 0; a < lword + 4; a++)
            {
                Console.Write("*");

            }
            Console.WriteLine("");
            foreach (var str in strings)
            {
                Console.Write($"* {str}");
                for (var b = 1; b <= lword + 1 - str.Length; b++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
            for (var a = 0; a < lword + 4; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}