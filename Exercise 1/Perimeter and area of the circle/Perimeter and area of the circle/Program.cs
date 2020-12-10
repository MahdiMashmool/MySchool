using System;

namespace Perimeter_and_area_of_the_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float radius = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the radius of the circle: ");
                radius = float.Parse(Console.ReadLine());
                Console.Write("Area: ");
                Console.WriteLine(Area(radius));
                Console.Write("Environment: ");
                Console.WriteLine(Environment(radius));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Perss any key to try agian (:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        #region voids
        static float Area(float _redius)
        {
            return _redius * _redius * 3.14f;
        }
        static float Environment(float _redius)
        {
            return (_redius * 2) * 3.14f;
        }
        #endregion
    }
}
