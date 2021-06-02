using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// This method makes sure that the user doesn't input the wrong value
        /// and repeats the process until a correct value is given
        /// </summary>
        /// <param name="choices"></param>
        /// <returns></returns>
        public static int SelectChoice(string[] choices)
        {
            int choiceNo = 0;

            //Display all the choices

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"|{choiceNo}. {choice}");
            }

            choiceNo = InputNumberWithin(choiceNo - choiceNo + 1, choices.Length);

            return choiceNo;
        }

        /// <summary>
        /// This method checks that the number is within limit 
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;

            } while (!isValid);

            return number;

        }

        /// <summary>
        /// This method checks the input number and if number
        /// is false the method will ask for a different number
        /// </summary>
        /// <returns></returns>
        public static double InputNumber()
        {
            double number = 0;
            bool Isvalid = false;

            do
            {
                Console.Write(">");
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    Isvalid = true;
                }
                catch (Exception)
                {
                    Isvalid = false;
                    Console.WriteLine("Number is INVALID!!!");
                }
            }
            while (!Isvalid);
            return number;

        }
        
        /// <summary>
        /// This method checks the input number and if number
        /// is false the method will ask for a different number
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool Isvalid = false;

            do
            {
                Console.Write(">");
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    Isvalid = true;
                }
                catch (Exception)
                {
                    Isvalid = false;
                    Console.WriteLine("Number is INVALID!!!");
                }
            }
            while (!Isvalid);
            return number;

        }

        /// <summary>
        /// This method checks the value of the number
        /// </summary>
        /// <param name="value"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static bool InRange(double value, double from, double to)
        {
            if (value >= from && value <= to)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method checks the input number and keeps it within the value
        /// any number that is greater than will not count
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static int InputNumberWithin(int from, int to)
        {
            int number;
            bool Isvalid;

            do
            {
                double value = InputNumber();

                number = Convert.ToInt32(value);
                Isvalid = true;

                if (number < from || number > to)
                {
                    Console.WriteLine($"Number must be between {from} and {to} !");
                    Isvalid = false;
                }
            }
            while (!Isvalid);

            return number;
        }

        /// <summary>
        /// This method displays the student name and the name of the application
        /// </summary>
        /// <param name="heading"></param>
        public static void OutputHeading(string heading)
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("              {heading}         ");
            Console.WriteLine("           By Brian Ruszkowski              ");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
