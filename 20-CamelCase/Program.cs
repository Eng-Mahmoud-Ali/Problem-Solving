using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_CamelCase
{
    class Program
    {
        // Complete the camelcase function below.
        static int camelcase(string s)
        {
            StringBuilder result = new StringBuilder("");
            bool currentIsSmall = char.IsLower(s[0]);
            for (int i = 0; i < s.Length; i++)
            {
                if (currentIsSmall == char.IsLower(s[i]))
                {
                    result.Append(s[i]);
                }
                else
                {
                    result.Append(",").Append(s[i]);
                    currentIsSmall = !char.IsLower(s[i]);
                }
            }
            return result.ToString().Split(',').Count();
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine(result);

        }
    }
}
