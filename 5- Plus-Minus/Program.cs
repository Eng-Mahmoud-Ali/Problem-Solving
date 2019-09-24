using System;
using System.Linq;

namespace _5__Plus_Minus
{
    class Program
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int arrayCount = arr.Count();
            int negativeCount = arr.Where(p => p < 0).Count();
            int positiveCount = arr.Where(p => p > 0).Count();
            int zeroCount = arr.Where(p => p == 0).Count();


            Console.WriteLine((decimal)positiveCount / arrayCount);
            Console.WriteLine((decimal)negativeCount / arrayCount);
            Console.WriteLine((decimal)zeroCount / arrayCount);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}
