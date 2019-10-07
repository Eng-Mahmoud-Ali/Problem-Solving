using System;

namespace _15_Breaking_the_Records
{
    class Program
    {
        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int max = scores[0];
            int minTry = 0;
            int maxTry = 0;
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    maxTry += 1;
                    max = scores[i];
                }
                else if (scores[i] < min)
                {
                    minTry += 1;
                    min = scores[i];
                }
            }
            return new int[] { maxTry, minTry };
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
            /*textWriter.WriteLine(string.Join(" ", result));
            textWriter.Flush();
            textWriter.Close();*/
        }
    }
}
