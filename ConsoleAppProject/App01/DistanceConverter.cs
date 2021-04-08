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

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        public void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        public void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        public void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" + 
                $" is {toDistance} {toUnit}!");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + "  feet is " + miles + " miles!");
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + "  miles is " + metres + " metres!");
        }

        private double InputMiles(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);

        }

        private void InputMetres(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

        }

        private void InputFeet(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("           Distance Converter            ");
            Console.WriteLine("           By Brian Ruszkowski              ");
            Console.WriteLine("--------------------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}