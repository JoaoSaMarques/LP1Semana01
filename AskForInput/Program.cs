using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer number:");
            string str = Console.ReadLine();

            int i = int.Parse(str);

            Console.WriteLine("Please input a real number:");
            string str2 = Console.ReadLine();

            float f = float.Parse(str2);

            float s = i + f;

            Console.WriteLine(s);

        }
    }
}
