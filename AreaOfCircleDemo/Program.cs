using System;

namespace AreaOfCircleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Please enter a radius: ");
            input = Console.ReadLine();
            double eval;

            if (!double.TryParse(input, out eval) || input == "")
            {
                Console.WriteLine("I am throwing a tantrum because you did not feed me! >:(");
                return;
            }
            
            double radius = double.Parse(input);
            
            while (radius < 0)
            {
                Console.WriteLine("Hey that's not a positive number! Enter a positive radius: ");
                radius = double.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("Please enter miles per gallon: ");
            double milesPerGallon = double.Parse(Console.ReadLine());
            double fuelConsumed = Circle.CalculateFuelConsumption(radius, milesPerGallon);

            Console.WriteLine("It will take " + fuelConsumed + " gallons of gas to go around the circle.");



        }
    }
}
