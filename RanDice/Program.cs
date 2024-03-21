using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            Random rand = new Random(seed);

            int total = 0;

            for (int i = 1; i <= count; i++)
            {
                total += rand.Next(1,7);
            }

            Console.WriteLine(total);
        }
    }
}
