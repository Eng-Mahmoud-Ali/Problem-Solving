using System;
using System.Collections.Generic;
using System.Linq;

namespace Diagonal_Difference
{
    class Result
    {
        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int arrayLength = arr.Count;
            int x = 0;
            int y = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                x += arr[i][i];
            }
            int oX = 0;
            for (int o = arrayLength - 1; o >= 0; o--)
            {
                y += arr[oX][o];
                oX++;
            }
            int result = x - y;
            return result < 0 ? result * -1 : result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            /*textWriter.WriteLine(result);
             textWriter.Flush();
             textWriter.Close();*/
        }
    }
}
