using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture =
                CultureInfo . InvariantCulture ; 

            // Peça ao utilizador para insesir um número real
            Console.WriteLine("Insira um número real: ");
            string RealFirst = Console.ReadLine();

            // Peça ao utilizador para insesir o segundo numero
            Console.WriteLine("Insira o segundo número real: ");
            string RealSecond = Console.ReadLine();

            // Peça ao utilizador para insesir o terceiro numero
            Console.WriteLine("Insira o terceiro número real: ");
            string RealThird = Console.ReadLine();

            // Peça ao utilizador para insesir o quarto numero
            Console.WriteLine("Insira o quarto número real: ");
            string RealFourth = Console.ReadLine();

            Console.WriteLine($"Nums:\n {RealFirst,8:F2}\n {RealSecond,8:F2}" +
            $"\n {RealThird,8:F2}\n {RealFourth,8:F2}");
        }
    }
}
