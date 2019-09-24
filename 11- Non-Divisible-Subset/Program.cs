using System;
using System.Collections.Generic;
using System.Linq;

namespace _11__Non_Divisible_Subset
{
    class Result
    {

        /*
         * Complete the 'nonDivisibleSubset' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY s
         */

        public static int nonDivisibleSubset(int k, List<int> s)
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = Result.nonDivisibleSubset(k, s);
            Console.WriteLine(result);

            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
