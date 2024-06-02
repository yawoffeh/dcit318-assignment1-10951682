using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Please enter your age:");
            
            string input = Console.ReadLine();
            
            // Check if the input is a valid integer
            if (int.TryParse(input, out age))
            {
                // Check if the age is within a reasonable range
                if (age >= 0 && age <= 120)
                {
                    int ticketPrice;

                    // Determine the ticket price based on age
                    if (age <= 12 || age >= 65)
                    {
                        ticketPrice = 7;
                    }
                    else
                    {
                        ticketPrice = 10;
                    }

                    Console.WriteLine($"The ticket price is: GHC {ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid age between 0 and 120.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Age must be a valid number");
            }
        }
    }
}

