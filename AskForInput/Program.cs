using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Peça ao utilizador para inserir um número inteiro
            Console.Writeline("Insira um número inteiro: ");
            string inputInteiroInt = Console.ReadLine();

            // Convert string to int
            int i = int.Parse(inputInteiroInt);

            // Peça ao utilizador para insesir um número real
            Console.Writeline("Insira um número real: ");
            string inputRealInt = Console.ReadLine();

            // Convert string to float
            float f = float.Parse(inputRealInt);

            // Soma
            float soma = i + f;
            Console.WriteLine($"Result of both numbers combined: {soma}");
        }
    }
}
