using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
