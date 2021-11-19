using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfCircleDemo
{
    public static class Circle
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI* Math.Pow(radius, 2);
        }

        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double CalculateDiameter(double radius)
        {
            return 2 * radius;
        }

        public static double CalculateFuelConsumption(double radius, double milesPerGallon)
        {
            return CalculateCircumference(radius) / milesPerGallon;
        }
    }
}
