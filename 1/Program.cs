using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int[] mass = new int[n];
            Random r = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-35, 45);
            }
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < mass.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = mass.Length - 1; i >= 0; i--)
            {               
                if (mass[i] >= 0)
                {
                    Console.Write(mass[i] + " ");
                    k++;
                    if (k % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

        }

    }
}