using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            double area = CalculatingArea(width, height);
            
            Console.WriteLine(area);
        }

        static double CalculatingArea(double width, double height)
        {
            return width * height;
        }
    }
}
