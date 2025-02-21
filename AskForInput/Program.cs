using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask for input of integer number
            Console.WriteLine("Please input an integer number:");
            string str = Console.ReadLine();

            // Convert string to int
            int i = int.Parse(str);

            // Ask for input of real number
            Console.WriteLine("Please input a real number:");
            string str2 = Console.ReadLine();

            // Convert string to float
            float f = float.Parse(str2);

            // Turn result into float
            float s = i + f;

            Console.WriteLine(s);

        }
    }
}
