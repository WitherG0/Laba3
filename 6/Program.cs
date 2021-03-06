using System;

namespace Sixth
{
    class Program
    {
        public static int sumIterative(int[] matrix)
        {
            int ansver = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                ansver += matrix[i];
            }
            return ansver;
        }
        public static int sumRecursive(int[] matrix, int i = 0)
        {
            if (i >= matrix.Length)
            {
                return 0;
            }
            else
            {
                int ansver = sumRecursive(matrix, i + 1);
                return ansver += matrix[i];
            }
        }
        public static int minIterative(int[] matrix)
        {
            int min = matrix[0];
            for (int i = 1; i < matrix.Length; i++)
            {
                if (min > matrix[i])
                {
                    min = matrix[i];
                }
            }
            return min;
        }
        public static int minRecursive(int[] matrix, int i = 0)
        {

            if (i == matrix.Length - 1)
            {
                return matrix[i];
            }
            return Math.Min(matrix[i], minRecursive(matrix, i + 1));

        }
        static void Main(string[] args)
        {
            int[] Matrix = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Matrix[i] = rand.Next(1, 100);
                Console.Write(Matrix[i] + " ");
            }
            int ansver2 = sumRecursive(Matrix);
            Console.WriteLine();
            Console.WriteLine(sumIterative(Matrix));
            Console.WriteLine(sumRecursive(Matrix));
            Console.WriteLine(minIterative(Matrix));
            Console.WriteLine(minRecursive(Matrix));

        }
    }
}
