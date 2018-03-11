using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

           switch (type)
            {
                case "face":   
                    Console.WriteLine($"{FaceCalculate(side):f2}"); 
                    break;
                case "space":
                    Console.WriteLine($"{SpaceCalculate(side):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{VolumeCalculate(side):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{AreaCalculate(side):f2}");
                    break;
            }
        }

         static object AreaCalculate(double side)
        {
            double area = 6 * (side * side);
            return area;
        }

        static object VolumeCalculate(double side)
        {
            double area = side * side * side;
            return area;
        }

        static object SpaceCalculate(double side)
        {
            double area = Math.Sqrt(3 * (side * side));
            return area;
        }

        static double FaceCalculate(double side)
        {
            double area = Math.Sqrt(2*(side * side));
            return area;
        }
    }
}
