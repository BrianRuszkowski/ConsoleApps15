using System;

namespace ConsoleAppProject.App02
{
    ///<summary>
    ///
    ///</summary>
    public enum UnitSystems
    {
        Metric
        Imperial
    }

    /// <summary>
    /// Please describe the main features of this App
    /// 
    /// 
    /// </summary>
    /// <author>
    /// Brian Ruszkowski version 0.1
    /// </author>
    public class BMI
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStone = 14;

        private double index;

        // Metric Details

        private double kilograms;
        private double metres;

        // Imperial Details

        private double pounds;
        private int inches;

        ///<summary>
        ///
        /// 
        /// </summary>
        public void CalculateIndex()
        {
            ConsoleHelper.OutputHeading("Body Mass Undex Calculator");

            UnitSystems unitSystems = SelectUnits();

            if (unitSystems == UnitSystems.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }

            OutputHealthMessage();
        }

        public void CalculateMetricBMI()
        {
            index = kilograms / (metres * metres);
        }

        public void CalculateImperialBMI()
        {
            index = pounds * 703 / (inches * inches);
        }

        /// <summary>
        /// 
        /// 
        /// </summary>




        private UnitSystems SelectUnits()
        {


























            inches += (int)feet * InchesInFeet;

            Console.WriteLine();
            Console.WriteLine(" Enter your weight in stones and pounds");
            Console.WriteLine();

            double = InputNumber(" Enter your weight in stones > ");
            pounds = InputNumber(" Enter your weight in pounds >  ");

            pounds += stones * PoundsInStones;
        }

        ///<summary>
        ///
        /// 
        /// </summary>
        private void InputMetricDetails()
        {
            metres = InputNumber(
                " \n Enter your height in metres > ");

            kilograms = InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        private void OutputHealthMessage()
        {
            Console.WriteLine();

            if (Index < Underweight)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are underweight! ");
            }
            else if (index <= NormalRange)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are in the normal range! ");
            }
            else if (index <= Overweight)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are overweight! ");
            }
            else if (index <= ObeseLevel1)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class I! ");
            }
            else if (index <= ObeseLevel2)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class II! ");
            }
            else if (index <= ObeseLevel3)
            {
                Console.WriteLine($" Your BMI is {index:0.00}, " +
                    $"You are obese class III! ");
            }

            OutputBameMessage();
        }

        /// <summary>
        ///
        /// 
        /// </summary>
        private void OutputBameMessage()
        {
            Console.WriteLine();
            Console.WriteLine(" If you are Black, Asian or other minority");
            Console.WriteLine(" ethnic groups, you have a higher risk");
            Console.WriteLine();
            Console.WriteLine("\t Adults 23.0 or more are at increased risk");
            Console.WriteLine("\t Adults 27.5 or more are at high risk");
            Console.WriteLine();
        }

        public double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);

            return number;
        }