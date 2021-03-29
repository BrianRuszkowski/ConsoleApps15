using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>   
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + "  miles is " + feet + " feet!");
        }

        public void CalculateFeet()
        {
            InputMiles();

            feet = miles * FEET_IN_MILES;

            OutputFeet();
        }

            private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("          Convert Miles to Feet             ");
            Console.WriteLine("           By Brian Ruszkowski              ");
            Console.WriteLine("--------------------------------------------\n");
            
        }
    }
}
