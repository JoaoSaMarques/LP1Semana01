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

            //Printing the values
            Console.WriteLine($"String 1: {str1}, {str2}, {str3}, {str4}");
        }
    }
}
