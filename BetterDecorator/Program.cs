using System;

namespace BetterDecorator
{
    /// <summary>
    /// Programa para decorar uma string.
    /// </summary>
    class Program
    {
        static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        static void Main(string[] args)
        {
            if (args.Length != 3)
        }
    }
}
