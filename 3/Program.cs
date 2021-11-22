using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Cдвигать массив влево: ");
            int b = int.Parse(Console.ReadLine());
            int[] array = new int[a];
            int[] array_n = new int[a];
            Console.WriteLine("Массив:");
            for (int i = 0; i < a; i++)
            {
                array[i] = i;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                array_n[i] = (i + b) % array.Length;
                Console.Write(array_n[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
