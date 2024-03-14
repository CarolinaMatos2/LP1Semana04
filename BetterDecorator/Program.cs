using System;

namespace BetterDecorator
{
    /// <summary>
    /// Programa para decorar uma string.
    /// </summary>
    class Program
    {
        private static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*'))
            Console.WriteLine(Decor("Good Evening! ", '.'))
        }
    }
}
