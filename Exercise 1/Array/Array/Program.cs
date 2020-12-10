using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] Students = new string[4][];
            Students[0] = new string[3] { "Riazi", "Farsi", "Dini" };
            Students[1] = new string[1] { "Riazi" };
            Students[2] = new string[4] { "Riazi", "Farsi", "Dini", "Zist" };
            Students[3] = new string[2] { "Riazi", "Farsi" };
            for (int i = 0; i < 4; i++)
            {
                int count = 0;
                switch (i)
                {
                    case 0:
                        count = 3;
                        Console.WriteLine("Ali");
                        break;
                    case 1:
                        count = 1;
                        Console.WriteLine("Reza");
                        break;
                    case 2:
                        count = 4;
                        Console.WriteLine("Mohammad");
                        break;
                    case 3:
                        count = 2;
                        Console.WriteLine("Hasan");
                        break;
                }
                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine(Students[i][j]);
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
