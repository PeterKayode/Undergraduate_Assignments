// NAME: KAYODE PETER TEMITOPE
// MARIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE (200 Level)
//COURSE: OBJECT ORIENTED PROGRAMMING (CSC 235)

using System;

namespace CGPA_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declaring the variable sting, integer and double
			string user_name, user_sex, user_address, course_name, letter_grade;
			int user_age, course_num, course_unit, course_score, score_point = 0, course_count = 1;
			double twgp = 0, cum_gpa, total_num_unit = 0, grade_point;

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

				//calculating the gradepoint, total weigh point and total number of units
				grade_point = course_unit * score_point;
				twgp = twgp + grade_point;
				total_num_unit = total_num_unit + course_unit;
				Console.WriteLine();
				course_count++;

			}

			//calculating the cgpa
			Console.WriteLine();
			Console.WriteLine("Your Total Number of Units is: " + total_num_unit);
			Console.WriteLine("Your Total Weigh Grade Point is: " + twgp);
			cum_gpa = twgp / total_num_unit;
			cum_gpa = Math.Round(cum_gpa, 2);
			Console.WriteLine("Your CGPA is: " + cum_gpa);

			//using switch to determine the class degree of the student (firstclass,second class upper, second class lower, third class, fail)
			switch (cum_gpa)
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