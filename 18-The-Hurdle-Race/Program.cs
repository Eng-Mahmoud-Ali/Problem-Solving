using System;
using System.Linq;
namespace _18_The_Hurdle_Race
{
    class Program
    {
        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            if (k > max)
                return 0;
            return max - k; 
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
            int result = hurdleRace(k, height);

            Console.WriteLine(result);
        }
    }
}
