using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais entre 0 e 1:");
            string S1 = Console.ReadLine();
            string S2 = Console.ReadLine();
            string S3 = Console.ReadLine();
            string S4 = Console.ReadLine();

            float F1 = float.Parse(S1);
            float F2 = float.Parse(S2);
            float F3 = float.Parse(S3);
            float F4 = float.Parse(S4);

            Console.WriteLine(F1.ToString("P2", CultureInfo.InvariantCulture).PadLeft(8));
            Console.WriteLine(F2.ToString("P2", CultureInfo.InvariantCulture).PadLeft(8));
            Console.WriteLine(F3.ToString("P2", CultureInfo.InvariantCulture).PadLeft(8));
            Console.WriteLine(F4.ToString("P2", CultureInfo.InvariantCulture).PadLeft(8));

        }
    }
}
