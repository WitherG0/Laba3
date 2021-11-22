using System;

namespace Ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество значений массива");
            int a = int.Parse(Console.ReadLine());
            int[] mas = new int[a];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-5, 5);
                if (mas[i] == 0)
                {
                    mas[i] = r.Next(-5 ,5);
                    continue;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            int k = 1;
            int p = 1;
            for (int i = 0; i < mas.Length; i = i + 2)
            {
                if (i >= mas.Length - 1) 
                {
                    if (mas[i] >= 0)
                    {
                        k = k * 1;
                    }
                    else
                    {
                        k = k * 0;
                    }
                    break;
                } 
                else if (mas[i] >= 0 & mas[i + 1] < 0) 
                {
                    k = k * 1; 
                }
                else
                {
                    k = k * 0;
                }
            }
            for (int i = 0; i < mas.Length-1; i = i + 2)
            {
                if (i >= mas.Length - 1)
                {
                    if (mas[i] < 0)
                    {
                        p = p * 1;
                    }
                    else
                    {
                        p = p * 0;
                    }
                    break;
                }
                else if(mas[i] < 0 & mas[i + 1] >=  0)
                {
                    p = p * 1;
                }
                else
                {
                    p = p * 0;
                }
            }
            Console.WriteLine();
            if (k == 1) { Console.WriteLine("TRUE"); } else { Console.WriteLine("FALSE"); }
        }
    }
}
