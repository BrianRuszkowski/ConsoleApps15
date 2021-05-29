using System;

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
                "Brian", "Blend", "Eliott",
                "Tom", "Ash", "Lian",
                "Jack", "Liam", "Jess",
                "Shamial"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void OutputMenu()
        {
            string[] choices = new string[]
            {
                "Input Marks", "Output Marks", "Output Stats", "Output Grade Profile", "Quit", "giveMarksTesting()", "giveMarksTo()"
            };

            bool finished = false;
            do
            {
                Console.WriteLine();
                switch (ConsoleHelper.SelectChoice(choices))
                {
                    case 1:
                        InputMarks();
                        break;

                    case 2:
                        OutputMarks();
                        break;


                    case 3:
                        CalculateGradeProfile();
                        OutputGradeProfile();
                        break;

                    case 4:
                        Console.WriteLine(@"Now quitting Student Grades");

                        finished = true;
                        break;

                    case 5:
                        giveMarksTesting();
                        break;

                    case 6:
                        giveMarksTo(Console.ReadLine(), (int)ConsoleHelper.InputNumber());
                        break;
                }
            } while (!finished);
        }


        public void InputMarks()
        {
            int i = 0;

            foreach (string student in Students)
            {
                Console.WriteLine($"Enter the marks for {student} >");
                Marks[i] += ConsoleHelper.InputNumberWithin(LowestMark, HighestMark);
                i++;
            }
        }

        public int giveMarksTo(string name, int mark)
        {
            int i = 0;

            foreach (string student in Students)
            {
                if (!ConsoleHelper.InRange(mark, LowestMark, HighestMark))
                {
                    return -1;
                }

                string correctName = student;
                if (correctName == name)
                {
                    Marks[i] += mark;
                    break;
                }
                else
                {
                    i++;
                }
            }

            return Marks[i];
        }

        public void OutputMarks()
        {
            Console.WriteLine("Output Marks :");
            Console.WriteLine();
            int i = 0;

            foreach (string student in Students)
            {
                Console.WriteLine($" Marks for {student} :| {Marks[i]} |");
                i++;
            }
        }

        public Grades ConvertToGrade(int mark)
        {
            if (ConsoleHelper.InRange(mark, LowestGradeA, HighestMark) || mark > 100)
            {
                return Grades.A;
            }
            else if (ConsoleHelper.InRange(mark, LowestGradeB, LowestGradeA - 1))
            {
                return Grades.B;
            }
            else if (ConsoleHelper.InRange(mark, LowestGradeC, LowestGradeB - 1))
            {
                return Grades.C;
            }
            else if (ConsoleHelper.InRange(mark, LowestGradeD, LowestGradeC - 1))
            {
                return Grades.D;
            }
            else
            {
                return Grades.F;
            };
        }

        public void CalculateStats()
        {
            double total = 0;

            foreach (int mark in Marks)
            {
                total = total = mark;
            }

            Mean = total / Marks.Length;

            Maximum = 0;
            foreach (int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
            }

            Minimum = 100;
            foreach (int mark in Marks)
            {
                if (mark < Minimum)
                {
                    Minimum = mark;
                }
            }
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

        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();

        }

        public void giveMarksTesting()
        {
            int i = 0;
            Random r = new Random();
            foreach (string student in Students)
            {
                Marks[i] += r.Next(0, 100);
                Console.WriteLine($"{student} marks : {Marks[i]}");
                i++;
            }
        }
    }
}