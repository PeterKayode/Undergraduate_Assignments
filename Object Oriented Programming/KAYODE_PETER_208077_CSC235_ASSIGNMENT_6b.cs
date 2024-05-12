using System;

namespace Assignment_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAME: KAYODE PETER TEMITOPE
        	// MATRIC NUMBER: 208077
        	// DEPARTMENT: COMPUTER SCIENCE (200 LEVEL)
        	
        	// Declaring the variable, float and double 
           float principal, rate_raw, rate, time, rn, nt, compound_interest;
           double rn_power;
           
           // Accepting input for the Principal
           Console.WriteLine("Enter P(Principal): ");
           principal = float.Parse(Console.ReadLine());
           
           // Accepting input for the Rate
           Console.WriteLine("Enter R(Rate): ");
           rate_raw = float.Parse(Console.ReadLine());
           rate = rate_raw / 100;
           
           // Accepting input for the Time
           Console.WriteLine("Enter T(Time): ");
           time = float.Parse(Console.ReadLine());
           
           // Listing all the parameters enters
           Console.WriteLine();
           Console.WriteLine("Parameters entered are:");
           Console.WriteLine("Principal = " + principal);
           Console.WriteLine("Rate = " + rate_raw);
           Console.WriteLine("Time = " + time);
           Console.WriteLine();

           // Calculating the Compound Interest
           rn = 1 + rate;
           rn_power = Math.Pow(rn, time);
           // Converting a double to float and performing operation
           nt = (float)(rn_power - 1);
           compound_interest = principal * nt;
           
           // Printing the Compound Interest
           Console.WriteLine("Compound Interest = " + compound_interest);
        }
    }
}
