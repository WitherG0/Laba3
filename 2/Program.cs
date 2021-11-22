using System;

namespace Second
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] mass = new int[7, 7];        
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    mass[i, j] = rand.Next(0, 9);
                    Console.Write(mass[i, j] + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mass[7 - j - 1, i] + " ");
                }
            }
        }
    }
}