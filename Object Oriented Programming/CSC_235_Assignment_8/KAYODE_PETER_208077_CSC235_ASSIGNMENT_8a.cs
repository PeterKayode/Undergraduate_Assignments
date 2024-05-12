// NAME: KAYODE PETER TEMITOPE
// MATRIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           // Declaring some variables string
           string st1, st2, str1, str2;
           
           // Accepting input for the first string
           Console.WriteLine("Input String 1: ");
           st1 = Console.ReadLine();
           // Accepting input for the second string
           Console.WriteLine("Input Sting 2: ");
           st2 = Console.ReadLine();
           Console.WriteLine();

           str1 = String.Concat(st1.OrderBy(c => c));
           str2 = String.Concat(st2.OrderBy(c => c));

           // Deciding and printing if the first string characters are the same with the second string characters
           if (str1 == str2)
           {
             Console.WriteLine($"{st1} and {st2} are Anagrams");
           }
           else
           {
             Console.WriteLine($"{st1} and {st2} are not Anagrams");
           }
        }
    }
} 