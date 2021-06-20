using System;

namespace _57_Random
{
    class RandomEx
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for(int i = 0; i < 100; i++)
            {
                Console.CursorLeft = rand.Next(80);
                Console.CursorTop = rand.Next(24);
                Console.Write("*");
            }
        }
    }
}
