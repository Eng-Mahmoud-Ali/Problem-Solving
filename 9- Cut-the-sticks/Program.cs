using System;
using System.Collections.Generic;
using System.Linq;
namespace _9__Cut_the_sticks
{
    class Program
    {
        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            List<int> countResult = new List<int>();
            while (arr.Any(p => p > 0))
            {
                countResult.Add(arr.Count(p => p > 0));
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        arr[i] = arr[i] - 1;
                    }
                }
            }
            countResult = countResult.Distinct().ToList();
            return countResult.ToArray();
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] result = cutTheSticks(arr);
            Console.WriteLine(string.Join("\n", result));

            /*textWriter.WriteLine(string.Join("\n", result));
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
