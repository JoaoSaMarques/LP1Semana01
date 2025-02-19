using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;


            // Strings with escape characters
            string str1 = "Hello\tWorld!";  // Tab character
            string str2 = "Line 1\nLine 2";  // New line
            string str3 = "Path: C:\\Users\\";  // Backslash
            
            // Strings with Unicode characters
            string str4 = "Euro symbol: \u20AC";  // Euro symbol
            string str5 = "Smiley: \u263A";  // Smiley face
            string str6 = "Japanese: \u3042\u3044\u3046";  // Japanese characters
            
            // Printing all strings
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);

            // Variables for concatenation 
            int num = 2;
            string text = "abc";

            // Concatenation
            string concat1 = "a" + num;  // "a" + 2
            string concat2 = text + "x"; // "abc" + "x"

            // Variables for interpolation 
            int x = 5;
            int y = 10;
            
            // Interpolation 
            string interp1 = $"O valor de x é {x}";
            string interp2 = $"{x} mais {y} é igual a {x + y}";

            // Print all string values
            Console.WriteLine("Concatenação:");
            Console.WriteLine(concat1);
            Console.WriteLine(concat2);
            
            Console.WriteLine("\nInterpolação:"); 
            Console.WriteLine(interp1);
            Console.WriteLine(interp2);
        }
    }
}