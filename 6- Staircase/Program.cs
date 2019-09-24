using System;
using System.Text;

namespace _6__Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder spaces = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                for (int s = 0; s < n-i; s++)
                {
                    spaces.Append(" ");
                }
                str.Append(spaces);
                for (int y = 0; y < i; y++)
                {
                    str.Append("#");
                }
                Console.WriteLine(str);
                str = new StringBuilder();
                spaces = new StringBuilder();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
