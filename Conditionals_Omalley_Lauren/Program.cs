using System;

namespace Conditionals_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a whole number and assigns the number to an integer variable
            Console.WriteLine("Enter a whole number, please!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Checks if the whole number is positve or negative
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number!");
            }

            // Cheks if the whole number is even or odd
            if(myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }

            // Creates two more integer numbers
            int num1 = 6;
            int num2 = 99;

            // Gets the first max
            int firstMax = Math.Max(myWholeNum, num1);

            // Gets the mazimum number
            int max = Math.Max(firstMax, num2);

            // Prints the max to the console
            Console.WriteLine($" The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");

            // Asks the user to enter a grade and assigns it to a char variable, grade
            Console.WriteLine("Enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;

            // prints description based on the grade value
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did mot enter a valid grade!");
                    break;
            }
        }
    }
}
