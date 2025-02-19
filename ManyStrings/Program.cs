using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // Variables for concatenation examples
            int num = 2;
            string text = "abc";
        }
    }
}