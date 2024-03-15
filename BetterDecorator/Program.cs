using System;

/// <summary>
/// Programa para decorar strings.
/// </summary>
namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// O ponto de entrada principal do programa.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando.</param>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string a = Decor();
                ConsoleWriteLine(a);
            }
            else if (args.Length == 3)
            {
                string b = args[0];
                char decora = args[1][0];
                string resultado = Decor(b, decora);
                Console.WriteLine(resultado);
            }
        }
    }
}
