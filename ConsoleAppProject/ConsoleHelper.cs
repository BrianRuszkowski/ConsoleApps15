using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        public static int SelectChoice(string[] choices)
        {
            int choiceNo = 0;

            //Display all the choices

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"|{choiceNo}. {choice}");
            }

            choiceNo = InputNumberWithin(choiceNo-choiceNo+1, choices.Length);

            return choiceNo;
        }


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

        public static void OutputHeading(string heading)
        {
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("              {heading}         ");
            Console.WriteLine("           By Brian Ruszkowski              ");
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
