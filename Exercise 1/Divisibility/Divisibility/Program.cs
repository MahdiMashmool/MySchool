using System;
using MahdiMashmool.Project.DivisibilityNumber;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter Your Number: ");
                number = int.Parse(Console.ReadLine());
                if (DivisibilityNumbers.Divisibility3and5(number))
                    Console.WriteLine("The number entered is divisible by 3 and 5");
                else
                    Console.WriteLine("The number entered on 3 and 5 is not divisible");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press any key to try again");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

