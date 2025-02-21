using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please input 4 real numbers between 0 and 1:");
            string S1 = Console.ReadLine();
            string S2 = Console.ReadLine();
            string S3 = Console.ReadLine();
            string S4 = Console.ReadLine();

            float F1 = float.Parse(S1);
            float F2 = float.Parse(S2);
            float F3 = float.Parse(S3);
            float F4 = float.Parse(S4);

            string result1 = F1.ToString("#0.##%");

            Console.WriteLine(F1.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine(F2.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine(F3.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine(F4.ToString("P", CultureInfo.InvariantCulture));

        }
    }
}
