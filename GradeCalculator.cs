using System;

namespace GradeCalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            string input = Console.ReadLine();
            int grade;
            
            if (int.TryParse(input, out grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string correspondingGrade;

                    if (grade >= 90)
                    {
						correspondingGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        correspondingGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        correspondingGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        correspondingGrade = "D";
                    }
                    else
                    {
                        correspondingGrade = "F";
                    }

                    Console.WriteLine($"The grade is: {correspondingGrade}");
                }
                else
                {
                    Console.WriteLine("Please enter a grade between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }
        }
    }
}

