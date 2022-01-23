using System;

namespace Sphere
{
    // main class
    public class Sphere
    {
        // main method
        public static void Main(string[] args) {
            // main method body
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3); 

            double area = 4 * Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The Volume is " + volume + "cm3 and\nThe area is " + area + "cm2");
        }
    }
}