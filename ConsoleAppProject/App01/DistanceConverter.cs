using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is my mesurement converter which you can can convert units from and to a 
    /// certain mesurment and get the output and the calculation for the mesurement
    /// </summary>
    /// <author>
    /// Brian Ruszkowski 21717237 version 1.0
    /// </author>   
    
    ///<summary>
    ///This code is for the value of each of the mesurement from and to value
    /// </summary>
    public class DistanceConverter
    {
        public const double FEET_IN_FEET = 1.0;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const double FEET_IN_MILES = 5280;

        public const double METRES_IN_METRES = 1.0;

        public const double MILES_IN_MILES = 1.0;

        public const double MILES_IN_FEET = 0.000189393939;

        public const double METRES_IN_FEET = 0.3048;

        public const double MILES_IN_METRES = 0.000621371192;

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

        /// <summary>
        /// Distance converter this code outputs the comment to select mesurment to and from 
        /// and shows which mesurments you have selected it also calculates both mesurments selected
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Distance calculator this code allows the user to select the to and from unit
        /// and giving them the convertion calculation 
        /// </summary>
        private void CalculateDistance()
        {
            if(fromUnit == FEET && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_FEET;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance / MILES_IN_FEET;
            }
            else if (fromUnit == MILES && toUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance / MILES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / METRES_IN_FEET;
            }
            else if (fromUnit == METRES && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
        }

        /// <summary>
        /// This code displays which choice the user has selected the to and from measurements
        /// and shows both units chosen
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// This code is for the choices which allow the user to input which 
        /// conversion of measurement they want to choose to and from
        /// </summary>
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }


        /// <summary>
        /// This code displays options of conversion for the user to unit and from unit
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// This code is for the input of the measurement
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// This code is for the output of the measurement 
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit}" + 
                $" is {toDistance} {toUnit}!\n");
        }

        /// <summary>
        /// This code displays what the app is and the authors name
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("           Distance Converter            ");
            Console.WriteLine("           By Brian Ruszkowski              ");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}