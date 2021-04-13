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

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");

            //CalculateFeet();

            OutputDistance();
        }

        private string SelectUnit(string prompt)
        {
            throw new NotImplementedException();
        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" + 
                $" is {toDistance} {toUnit}!");
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