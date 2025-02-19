using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Integer variables
            int i = 10;
            uint j = 20;
            short x = 0;
            long l = 35L;

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(x);
            Console.WriteLine(l);

            // Char variables
            char copyrightSymbol = '\u00A9';
            char newLine = '\u000A';

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);

            // Real variables
            float f = 3.1415f;
            double d = 3.2025;
            decimal m = 0.25m;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(m);

        }
    }
}
