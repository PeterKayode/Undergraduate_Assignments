using System;

namespace Assignment_6a
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAME: KAYODE PETER TEMITOPE
        	// MATRIC NUMBER: 208077
        	// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)
        	
        	// Declaring the variables, float 
           float principal, rate, time, simple_interest;
           
           // Accepting input for the Principal
           Console.WriteLine("Enter P(Pricipal): ");
           principal = float.Parse(Console.ReadLine());
           
           // Accepting input for the Rate
           Console.WriteLine("Enter R(Rate): ");
           rate = float.Parse(Console.ReadLine());
           
           // Accepting input for the Time
           Console.WriteLine("Enter T(Time): ");
           time = float.Parse(Console.ReadLine());
           
           // Displaying the parameters inputed
           Console.WriteLine();
           Console.WriteLine("Parameters inputed are:");
           Console.WriteLine("Principal = " + principal);
           Console.WriteLine("Rate = " + rate);
           Console.WriteLine("Time = " + time);
           Console.WriteLine();
           
           // To calculate the Simple Interest
           simple_interest = (principal * rate * time) / 100;
           
           // To print the Simple Interest
           Console.WriteLine("Simple Interest = " + simple_interest);
        }
    }
}
