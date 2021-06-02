using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This method contains all the information for the program
    /// such how many marks you need for a certain grade
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

        /// <summary>
        /// This method is for the list of student names whithin the
        /// application
        /// </summary>
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

        /// <summary>
        /// This method outputs the choices for the user and allows them 
        /// to choose what they want to do after a number has been entered
        /// it will take them to that choice
        /// </summary>
        public void OutputMenu()
        {
            string[] choices = new string[]
            {
                "Input Marks", "Output Marks", "Output Grade Profile", "Quit", "giveMarksTesting()", "giveMarksTo()"
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

        /// <summary>
        /// This method allows the user to input marks for all students
        /// </summary>
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

        /// <summary>
        /// This method allows the user to input marks for a specific student
        /// and checks if the name is correct for the student they wish to add
        /// marks for
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method displays all marks that each student has
        /// </summary>
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

        /// <summary>
        /// This method converts the amount of marks a student has into
        /// a specific grade that corresponds with their amount of marks
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method calculates the students stats and marks
        /// </summary>
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

        /// <summary>
        /// This method calculates mark to grade
        /// </summary>
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

        /// <summary>
        /// This method displays grade profile for the student
        /// </summary>
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

        /// <summary>
        /// This method gives the user the ability to add marks for testing
        /// </summary>
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