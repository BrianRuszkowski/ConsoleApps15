using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        // Attributes

        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "Dylan", "Eric",
                "Georgia", "Hasan", "Hamza",
                "Jack", "Liam", "Shan",
                "Shamial"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        private void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        private void InputMarks()
        {
            throw new NotImplementedException();
        }

        private void OutputMarks()
        {
            throw new NotImplementedException();
        }

        public Grades ConvertToGrade(int Mark)
        {
            if (Mark >= 0 && Mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (Mark >= LowestGradeD && Mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (Mark >= LowestGradeC && Mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (Mark >= LowestGradeB && Mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (Mark >= LowestGradeA && Mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

        public  void CalculateStats()
        {
            double total = 0;

            Minimum = HighestMark;
            Maximum = 0;

            foreach(int mark in Marks)
            {
                total = total = mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }

            Mean = total / Marks.Length;
        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void TestGradesEnumeration()
        {
            Grades grade = Grades.C;

            Console.WriteLine($"Grade = {grade}");
            Console.WriteLine($"Grade No = {(int)grade}");

            Console.WriteLine("\nDiscovered by Andrei!\n");
            var gradeName = grade.GetAttribute<DisplayAttribute>().Name;
            Console.WriteLine($"Grade Name = {gradeName}");

            var gradeDescription = grade.GetAttribute<DescriptionAttribute>().Description;
            Console.WriteLine($"Grade Description = {gradeDescription}");

            string testDescription = EnumHelper<Grades>.GetDescription(grade);
            string testName = EnumHelper<Grades>.GetName(grade);

            Console.WriteLine();
            Console.WriteLine("Discovered by Derek Using EnumHelper\n");
            Console.WriteLine($"Name = {testName}");
            Console.WriteLine($"Description = {testDescription}");
        }
    }
}
