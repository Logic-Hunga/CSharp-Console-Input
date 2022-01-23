using System;

namespace AreaOfCone
{
    // main class
    public class AreaOfCone
    {
        // main method
        public static void Main(String[] args)
        {
            // main method body
            // prompt the user to enter the radius,and height
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side: ");
            double side = double.Parse(Console.ReadLine());

            double surfaceArea = side * (side + Math.Sqrt(Math.Pow(side, 2) + 4 * Math.Pow(height,2)));
            // double surfaceArea = side * (side + )

            Console.WriteLine("The surface area is " + surfaceArea + "cm^2");
        }
    }
}