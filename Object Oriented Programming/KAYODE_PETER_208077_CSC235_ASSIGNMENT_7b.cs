// NAME: KAYODE PETER TEMITOPE
// MATRIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)

using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accepting number input from user
            Console.WriteLine("Enter a number");

            // Allowing response inputed to only be an integer
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);

            // Printing the Factorial of entered number out
            Console.WriteLine($"The factorial of {number} = {factorial}");
        }
        // Method for computing the number
        // Factorial can be queit a big number thats the reason we make use of double
        public void Factorial(int number)
        {
            // If the number provided is 0, it would return a result of 1 since 0 factorial is 1 
            if (number == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(number * Factorial(number - 1));
            }
        }
    }
}
