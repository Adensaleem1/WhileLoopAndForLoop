using System;

namespace WhileLoopAndForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Loop Demonstration Program!");
            Console.WriteLine("------------------------------------------");

            // Declare and initialize variables for While Loop
            int counter = 1;  // starting value
            int limit = 5;    // how many times to run

            Console.WriteLine("\nWHILE LOOP EXAMPLE:");
            // While loop that runs until counter equals limit
            while (counter <= limit)
            {
                Console.WriteLine($"Iteration {counter}: The loop is running...");
                counter++; // increment counter by 1
            }

            Console.WriteLine("\nThe while loop has finished!\n");

            // Declare variables for user input in For Loop example
            int num1, num2, total;

            Console.WriteLine("FOR LOOP EXAMPLE:");
            // For loop that runs three times
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nRound {i}: Let's add two numbers!");

                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                total = num1 + num2;
                Console.WriteLine($"The total of {num1} + {num2} = {total}");
            }

            Console.WriteLine("\nAll rounds completed! Great job!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

