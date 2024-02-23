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
            
            float a = float.Parse(RealFirst);

            // Peça ao utilizador para insesir o segundo numero
            Console.WriteLine("Insira o segundo número real: ");
            string RealSecond = Console.ReadLine();

            float b = float.Parse(RealSecond);

            // Peça ao utilizador para insesir o terceiro numero
            Console.WriteLine("Insira o terceiro número real: ");
            string RealThird = Console.ReadLine();

            float c = float.Parse(RealThird);

            // Peça ao utilizador para insesir o quarto numero
            Console.WriteLine("Insira o quarto número real: ");
            string RealFourth = Console.ReadLine();

            float d = float.Parse(RealFourth);

            Console.WriteLine($"Nums:\n {a,6:f2}\n {b,6:f2}" +
            $"\n {c,6:f2}\n {d,6:f2}");
        }
    }
}
