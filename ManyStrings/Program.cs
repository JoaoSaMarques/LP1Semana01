using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String variables
            string str1 = "Hello, World!";
            string str2 = "SCREW THIS.\nWOOOOOORLD!!";
            string str3 = "Is\tThis\tA\tString?";
            string str4 = "Unicode: \u0001 \u0002 \u0003";
            double xx = 3.1514;
            int ii = 10;

            //Printing the values
            Console.WriteLine($"String 1: {str1}, {str2}, {str3}, {str4}");

            //Concatenacao
            string conca1 = "a" + 2;
            int x = 5;
            string conca2 = "abc" + x;

            Console.WriteLine($"Concatenacoes: {conca1}, {conca2}");

            // Imprime xx
            Console.WriteLine($"Número real com duas casas decimais: {xx:F2}");
            Console.WriteLine($"Percentagem com uma casa decimal: {xx:P1}");

            // Imprime ii 
            Console.WriteLine($"Hexadecimal: 0x{ii:X}");
            Console.WriteLine($"Moeda: {ii:C}");
        }
    }
}
