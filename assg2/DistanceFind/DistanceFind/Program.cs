using System;

namespace LenghtOfLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cartesian coordinates of (x1,y1)");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cartesian coordinates of (x2,y2)");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double Lenght = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The lenght of the two points: " + Lenght);
            double m = (y2 - y1) / (x2 - x1);
            double c = (y1 - m * x1);
            Console.WriteLine("The equation of the Line is: y={0}x+{1}", m, c);
        }
    }
}