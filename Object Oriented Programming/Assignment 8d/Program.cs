// NAME: KAYODE PETER TEMITOPE
// MATRIC NUMBER: 208077
// DEPARTMENT: COMPUTER SCIENCE(200 LEVEL)


using System;
//using System.IO;
//using System.Linq;
//using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
			List<string> list = new List<string>() {"B", "a", "b", "a", "t", "u", "n", "d", "e"};
            IList<IList<string>> perms = Permutations(list);
            foreach (IList<string> perm in perms)
            {
                foreach (string s in perm)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }

        private static IList<IList<T>> Permutations<T>(IList<T> list)
        {
            List<IList<T>> perms = new List<IList<T>>();

            if (list.Count == 0)
                return perms; // Empty list.

            int factorial = 1;
            for (int i = 2; i <= list.Count; i++)
                factorial *= i;

            for (int v = 0; v < factorial; v++)
            {
                List<T> s = new List<T>(list);                
                int k = v;
                for (int j = 2; j <= list.Count; j++)
                {
                    int other = (k % j);
                    T temp = s[j - 1];
                    s[j - 1] = s[other];
                    s[other] = temp;

                    k = k / j;
                }
                perms.Add(s);
            }
            return perms;
        }
    }
}