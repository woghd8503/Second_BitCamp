using System;

namespace _20_Character
{
    class Character
    {
        static void Main(string[] args)
        {
            char ch_a = 'a';
            char ch_b = 'b';
            char ch_A = 'A';
            char ch_B = 'B';
            char ch_Z = 'Z';
            char ch_z = 'z';

            Console.WriteLine(ch_a + "=" + (int)ch_a);
            Console.WriteLine(ch_b + "=" + (int)ch_b);
            Console.WriteLine(ch_A + "=" + (int)ch_A);
            Console.WriteLine(ch_B + "=" + (int)ch_B);
            Console.WriteLine(ch_Z + "=" + (int)ch_Z);
            Console.WriteLine(ch_z + "=" + (int)ch_z);

            Console.WriteLine(ch_a + 1);
            Console.WriteLine((char)(ch_a + 1));
        }
    }
}
