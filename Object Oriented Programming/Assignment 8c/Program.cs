// NAME: KAYODE PETER TEMITOPE
// MATRIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
            // Declaring the variable as string
            string Word;
             
            Word = "I know and I know if I can trust Him, He can save me from the impending doom if only I believe in Him";

            // Split the string using 'Space' and stored it as var variable
            var Value = Word.Split(' ');
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();

            //loop the splited string 
            for (int i = 0; i < Value.Length; i++)
            {  
                if (RepeatedWordCount.ContainsKey(Value[i]))
                {  
                    // Check if word already exist in dictionary update the count
                    int value = RepeatedWordCount[Value[i]];  
                    RepeatedWordCount[Value[i]] = value + 1;  
                }  
                else  
                {  
                    // if a string is repeated and not added in dictionary , here we are adding
                    RepeatedWordCount.Add(Value[i], 1);
                }  
            }

            // Create a free line as space
            Console.WriteLine();
            // Print "words and their counts"
            Console.WriteLine("Words and their counts: ");
            Console.WriteLine();

            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)  
            {  
                // Print the words in the sentence and their counts respectively
                Console.WriteLine(kvp.Key + " is repeated " + kvp.Value + " time(s)");  
            }
        }
    }
}