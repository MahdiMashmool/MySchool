using System;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationtable = new int[10, 10];
            Console.WriteLine("Multiplication table");
            for (int i = 0; i < multiplicationtable.GetLength(0); i++)
            {
                for (int j = 1; j < multiplicationtable.GetLength(1); j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write("  {0}  ", multiplicationtable[i, j] = i * j);
                    }
                    else
                    {
                        Console.Write("  {0} ", multiplicationtable[i, j] = i * j);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
