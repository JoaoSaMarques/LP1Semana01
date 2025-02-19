using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int i = 10;
            uint j = 20;
            short x = 0;
            long l = 35L;

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(x);
            Console.WriteLine(l);

            char copyrightSymbol = '\u00A9';
            char newLine = '\u000A';

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);

        }
    }
}
