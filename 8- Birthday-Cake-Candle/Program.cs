using System;
using System.Collections.Generic;
using System.Linq;

namespace _8__Birthday_Cake_Candle
{
    class Program
    {
        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            int maxValue = ar.Max();
            var countAr = ar.Where(p => p == maxValue).Count();
            return countAr;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
            /*textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
