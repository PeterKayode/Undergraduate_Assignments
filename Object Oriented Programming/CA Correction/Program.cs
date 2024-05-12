using System;

namespace CGPA_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaring the variable sting, integer and double
			string user_name, user_sex, user_address, course_name, letter_grade;
			int user_age, course_num, course_unit, course_score, score_point = 0, course_count;
			double twgp, final_cgpa = 0, total_num_unit, grade_point, final_unit = 0, final_twgp = 0;

			//Accepting user biodata
			Console.WriteLine("Enter your name: ");
			user_name = Console.ReadLine();
			Console.WriteLine(" ");
			Console.WriteLine("Input your Age: ");
			user_age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" ");
			Console.WriteLine("Input your Sex(Male or Female): ");
			user_sex = Console.ReadLine();
			Console.WriteLine(" ");
			Console.WriteLine("Input your Address: ");
			user_address = Console.ReadLine();
			Console.WriteLine(" ");
			
			//Accepting user number of courses
			Console.WriteLine("Enter Number of Courses: ");
			course_num = Convert.ToInt32(Console.ReadLine());

			//using for loop for iterations of courses details
			for (int i = 0; i < course_num; i++)
			{
				Console.WriteLine("Enter the Course Name:\n ");
				course_name = Console.ReadLine();
				Console.Write(" ");
				Console.WriteLine("Enter course unit: ");
				course_unit = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");
				Console.WriteLine("Enter your score: ");
				course_score = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" ");

				//using switch to grade the scores according to points and letters (A, B,C, D, E)
				switch (course_score)
				{
					case int n when n > 100:
						Console.WriteLine("Invalid input, try running the program again");
						break;

					case int n when n >=70:
						score_point = 4;
						letter_grade = "A";
						Console.WriteLine("Your point: {0}\nRemark: {1}", score_point, letter_grade);
						break;

					case int n when n >= 60:
						score_point = 3;
						letter_grade = "B";
						Console.WriteLine("Your point: {0}\nRemark: {1}", score_point, letter_grade);
						break;

					case int n when n >= 50:
						score_point = 2;
						letter_grade = "C";
						Console.WriteLine("Your point: {0}\nRemark: {1}", score_point, letter_grade);
						break;

					case int n when n >= 45:
						score_point = 1;
						letter_grade = "D";
						Console.WriteLine("Your point: {0}\nRemark: {1}", score_point, letter_grade);
						break;

					case int n when n >= 0:
						score_point = 0;
						letter_grade = "E";
						Console.WriteLine("Your point: {0}\nRemark: {1}", score_point, letter_grade);
						break;

					default:
						Console.WriteLine("Invalid input, try running the program again");
						break;
				}

                twgp = course_unit * score_point;
                final_twgp += twgp;
                final_unit += course_unit;
            }
            final_cgpa = final_twgp/final_unit;
            Console.WriteLine($"Your CGPA is {final_cgpa}");

            switch (final_cgpa)
			{
				case double n when n >= 3.5:
					Console.WriteLine("Your class of Degree is: First class");
					break;

				case double n when n >= 3.0:
					Console.WriteLine("Your class of Degree is: Second class Upper");
					break;

				case double n when n >= 2.0:
					Console.WriteLine("Your class of Degree is: Second class Lower");
					break;

				case double n when n >= 1.0:
					Console.WriteLine("Your class of Degree is: Third class");
					break;

				case double n when n >= 0:
					Console.WriteLine("Your class of Degree is: Fail");
					break;
			}
		}
	}
}