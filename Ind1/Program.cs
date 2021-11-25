using System;

namespace Ind1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] s = new int[9, 9];
            int i, x, k, Temp;
            k = x = Temp = 0;
            i = 8;
            s[i, k] = ++x;
            k++;
            while (x != 81)
            {
                s[i, k] = ++x;
                k--;
                i--;
                Temp++;
                if (k < 0 || i < 0)
                {
                    i = Temp + i;
                    k = k + Temp;
                    Temp = 0;
                    if (k == 8)
                    {
                        i--;
                    }
                    else
                    {
                        k++;
                    }
                }
            }
            for (int p = 0; p < 9; p++)
            {
                
                Console.WriteLine();
                Console.WriteLine(new String('_', 45));
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("|" + $"{s[p, j],3}" + "|");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new String('_', 45));
        }
    }
}
