using System;

namespace TriangleTypeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the length of the second side of the triangle:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the length of the third side of the triangle:");
            string input3 = Console.ReadLine();

            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                if (IsValidTriangle(side1, side2, side3))
                {
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    Console.WriteLine($"The triangle is: {triangleType}");
                }
                else
                {
                    Console.WriteLine("The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numerical values for the sides.");
            }
        }

        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}

