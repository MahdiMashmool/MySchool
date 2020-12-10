using System;

namespace triangle_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int[] sids = new int[3];
                Console.Write("Enter side 1: ");
                sids[0] = int.Parse(Console.ReadLine());
                Console.Write("Enter side 2: ");
                sids[1] = int.Parse(Console.ReadLine());
                Console.Write("Enter side 3: ");
                sids[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("Environment: {0}", Progress(sids[0], sids[1], sids[2]));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any kay for try again");
                Console.ReadKey();
                Console.Clear();
            }
        }
        #region voids
        static int Progress (int _side1, int _side2, int _side3)
        {
            return _side1 + _side2 + _side3;
        }
        #endregion
    }
}
