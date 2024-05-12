using System;

namespace KAYODE_PETER_208077_CSC235_ASSIGNMENT3
{
    class KAYODE_PETER_208077_CSC235_ASSIGNMENT3
    {
        static void Main(string[] args)
        {
            // NAME: KAYODE PETER TEMITOPE
            // MARIC NUMBER: 208077
            // DEPARTMENT: COMPUTER SCIENCE (200 Level)
            //COURSE: OBJECT ORIENTED PROGRAMMING (CSC 235)

            // SECTION A
            // A C# programm that can accept name from any user
            Console.Write("Enter your name: \n");
            Console.ReadLine();


            // SECTION B
            // QUESTION 1
            // To find V = Vo + at

            // Firstly, allow input for the value of Vo
            Console.WriteLine("Enter the value of Vo");
            var per_Vo = Convert.ToDouble(Console.ReadLine());

            // Secondly, allow input for the value of a
            Console.WriteLine("Enter the value of a");
            var per_a = Convert.ToDouble(Console.ReadLine());

            // Thirdly, allow input for the value of t
            Console.WriteLine("Enter the value of t");
            var per_t = Convert.ToDouble(Console.ReadLine());

            // Finally, the sum of Vo and at are done
            var final_V = per_Vo + (per_a * per_t);
            Console.WriteLine("V = Vo + at is {0:C} ", final_V);


            // QUESTION 2
            // To find ΔX = ((v + Vo)/2)t

            // Firstly, allow input for v
            Console.WriteLine("Enter the value of v");
            var per_v1 = Double.Parse(Console.ReadLine());

            // Secondly, allow input for Vo
            Console.WriteLine("Enter the value of Vo");
            var per_Voo = Double.Parse(Console.ReadLine());

            // Thirdly, allow input for t
            Console.WriteLine("Enter the value of t");
            var per_t1 = Double.Parse(Console.ReadLine());

            // Finally, divide the sum of v and Vo by two and multiply by t
            var final_ΔX = ((per_v1 + per_Voo) / 2) * per_t1;
            Console.WriteLine("ΔX = ((v + Vo)/2)t is {0:C} ", final_ΔX);



            // QUESTION 3
            //To find ΔX = vot + 1/2at

            // Firstly, allow input for vo
            Console.WriteLine("Enter the value of vo");
            var per_vo1 = Double.Parse(Console.ReadLine());

            // Secondly, allow input for t
            Console.WriteLine("Enter the value of t");
            var per_to1 = Double.Parse(Console.ReadLine());

            // Thirdly, allow input for a
            Console.WriteLine("Enter the value of a");
            var per_a1 = Double.Parse(Console.ReadLine());

            // Finally, add the product of v and t AND the half of the product of a and t together 
            var final_ΔX1 = ((per_vo1 * per_to1) + ((per_a1 * per_to1) / 2));
            Console.WriteLine("ΔX = ((v + Vo)/2)t is {0:C} ", final_ΔX1);




            //QUESTION 4
            // To find v2= v02 + 2aΔx

            // Firstly, allow input for vo
            Console.WriteLine("Enter the value of vo");
            var per_vo2 = Double.Parse(Console.ReadLine());

            // Secondly, allow input for a
            Console.WriteLine("Enter the value of a");
            var per_a2 = Double.Parse(Console.ReadLine());

            // Thirdly, allow input for Δx
            Console.WriteLine("Enter the value of Δx");
            var per_Δx2 = Double.Parse(Console.ReadLine());

            // Raise vo to the power of two
            double pow_vo2 = Math.Pow(per_vo2, 2);

            // Sum the raised vo AND the product of a and Δx together
            var final_v3 = ((pow_vo2) + (per_a2 * per_Δx2 * 2));

            // Finally, raise v to the power of two
            double pow_v3 = Math.Pow(final_v3, 2);
            Console.WriteLine("v2= v02 + 2aΔx is {0:C} ", pow_v3);

            // Pause program
            Console.Read();
        }
    }
}
