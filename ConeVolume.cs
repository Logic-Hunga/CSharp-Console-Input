using System;

namespace ConeVolume
{
    // main class
    public class ConeVolume
    {
        // main method
        public static void Main(string[] args)
        {
            // main method body
            // Enter the Cone entities
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side: ");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Computing the volume
            double volume = (1.0/3) * Math.PI *Math.Pow(radius,2) * height;

            Console.WriteLine("The volume is " + volume + " cm3");
        }
    }
}