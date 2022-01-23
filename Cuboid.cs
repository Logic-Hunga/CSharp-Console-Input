using System;

namespace Cuboid
{
    // main class
    public class Cuboid
    {
        //main method
        public static void Main(String[] args)
        {
            // main method body
            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter with: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            double area = 2 * (length * height + width * height + length * width);
            double volume = area * height;

            Console.WriteLine("Are is " + area + " cm2 and\nVolume is " + volume + "cm3");
        }
    }
}