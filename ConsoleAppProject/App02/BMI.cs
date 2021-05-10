
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This method allows the program to calculate metric and imperial measurements
    /// </summary>
    public enum UnitSystems
    {
        Metric,
        Imperial
    }

    /// <summary>
    /// This class contains methods for calculating
    /// the user's BMI (Body Mass Index) using
    /// imperial or metric units
    /// </summary>
    /// <author>
    /// Brian Ruszkowski App02: version 2.0
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
        public const int PoundsInStones = 14;

        private double index;

        // Metric Details

        private double kilograms;
        private double metres;

        // Imperial Details

        private double pounds;
        private int inches;

        /// <summary>
        /// This method outputs the heading for BMI and calculates the either imperial or 
        /// metric and outputs the health message
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

        /// <summary>
        /// This method calculates the metric measurements kilograms and metres
        /// </summary>
        public void CalculateMetricBMI()
        {
            index = kilograms / (metres * metres);
        }

        /// <summary>
        /// This method calculates the imperial measurements pounds and inches
        /// </summary>
        public void CalculateImperialBMI()
        {
            index = pounds * 703 / (inches * inches);
        }

        /// <summary>
        /// This method shows the user two choices that he can choose between
        /// either metric or imperial measurements and choose between one or the other
        /// </summary>
        private UnitSystems SelectUnits()
        {
            Console.WriteLine("1. Metric");
            Console.WriteLine("2. Imperial");
            int choice = (int)ConsoleHelper.InputNumber("Please Enter your choice > ", 1, 2);

            if (choice == 1)
            {
                return UnitSystems.Metric;
            }
            return UnitSystems.Imperial;
        }

        /// <summary>
        /// This method has the input details for metric details
        /// this method will output the message for the user to enter his metric details
        /// </summary>
        private void InputMetricDetails()
        {
            metres = ConsoleHelper.InputNumber(
                " \n Enter your height in metres > ", 1, 3);

            kilograms = ConsoleHelper.InputNumber(
                " Enter your weight in kilograms > ");
        }

        /// <summary>
        /// This method has all the measurement details for
        /// the imperial measurements and the output message for imperial details
        /// </summary>
        private void InputImperialDetails()
        {
            int stones = (int)ConsoleHelper.InputNumber(
                " Enter your weight in stones > ");

            pounds = (int)ConsoleHelper.InputNumber(
                " Enter your weight in pounds > ");

            pounds = pounds + stones * PoundsInStones;

            int feet = (int)ConsoleHelper.InputNumber("Please Enter your height in feet > ");

            inches = (int)ConsoleHelper.InputNumber(
                " Enter your hight in inches > ", 0, 12);
        }

        /// <summary>
        /// This method outputs the health message dependant
        /// on what your weight is 
        /// </summary>
        private void OutputHealthMessage()
        {
            Console.WriteLine();

            if (index < Underweight)
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
            else
                Console.WriteLine("Something Has Gone Very Wrong!!!");

            OutputBameMessage();
        }

        /// <summary>
        /// This method outputs the bame message at the end when the calculation
        /// finishes the bame messages shows the user who is at risk
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
    }
}