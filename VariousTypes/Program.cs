using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of Ints
            sbyte int0 = 127;
            short int1 = 32767;
            int int2 = 32;
            long int3 = 100;
            byte int4 = 255;
            ushort int5 = 65535;
            uint int6 = 100;
            ulong int7 = 100;

            Console.WriteLine($"Ints: {int0}, {int1}, {int2}, {int3}," +
            $" {int4}, {int5}, {int6}, {int7}");

            //List of chars with unicode
            char char1 = '\u0001'; 
            char char2 = '\u0009'; 
            char char3 = '\u000f'; 
            char char4 = '\u0080'; 

            Console.WriteLine($"chars: {char1}, {char2}, {char3}, {char4}");

            //List of reais
            float real1 = 3.14f;
            double real2 = 2.71828;
            decimal real3 = 123.456m;

            Console.WriteLine($"Reais: {real1}, {real2}, {real3}");

            //List of bools
            bool bool1 = 5 > 3;
            bool bool2 = false;

            Console.WriteLine($"Bools: {bool1}, {bool2}");
        }
    }
}
