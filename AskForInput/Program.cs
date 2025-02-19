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

        }
    }
}
