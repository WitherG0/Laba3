using System;

namespace Second
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int a;
            int[,] mass = new int[7, 7]/*{{ 0, 0, 0, 0, 0, 0, 0 }, {1,1,1,1,1,1,1 }, {2,2,2,2,2,2,2 }, {3,3,3,3,3,3,3 }, {4,4,4,4,4,4,4 }, {5,5,5,5,5,5,5 }, {6,6,6,6,6,6,6 }}*/;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    mass[i, j] = rand.Next(0, 9);
                    Console.Write(mass[i, j] + " ");
                }
            }

            /*for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {

                    Console.Write(mass[i, j] + " ");
                }
            }*/
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6- 2*i; j++)
                {
                    a = mass[i ,j + i];
                    mass[i, j + i] = mass[6 - j - i, i];
                    mass[6 - i, 6 - j - i] = mass[j + i, 6 - i];
                    mass[6 - j - i, i] = mass[6 - i, 6 - j - i]; 
                    mass[j + i, 6 - i] = a;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {

                    Console.Write(mass[i, j] + " ");
                }
            }
        }
    }
}
