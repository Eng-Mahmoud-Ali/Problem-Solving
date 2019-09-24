using System;
using System.Linq;
using System.Collections.Generic;

namespace _7__Mini_Max_Sum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int minIndex = 0;
            int maxIndex = 0;
            List<int> minArr = arr.ToList();
            List<int> maxArr = arr.ToList();
            //Get Min index 
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num < min)
                {
                    minIndex = i;
                    min = num;
                }
            }
            //Get Max index
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num > max)
                {
                    maxIndex = i;
                    max = num;
                }
            }

            //Remove the max of min arr
            minArr.RemoveAt(maxIndex);
            //Remove the min of max arr
            maxArr.RemoveAt(minIndex);

            //Sum both max and min arrays
            long minSum = minArr.Sum(p => (long)p);
            long maxSum = maxArr.Sum(p => (long)p);

            Console.WriteLine("{0} {1}", minSum, maxSum);
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
