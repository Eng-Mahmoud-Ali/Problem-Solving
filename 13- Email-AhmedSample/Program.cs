using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _13__Email_AhmedSample
{
    class Program
    {
        /// <summary>
        /*
         •	Write a function that takes an input like (“1234567892”) and print output like that:
            o	1
            o	23
            o	456
            o	7892
            o	Max 9999999
             */
        /// </summary>
        static void PrintDigits()
        {
            string line = Console.ReadLine();
            List<int> elements = line.Split(" ").Select(p => int.Parse(p)).ToList();
            StringBuilder str = new StringBuilder();
            int maxValue = elements[0];
            for (int i = 1; i < elements.Count + 1; i++)
            {
                if (maxValue < elements[i - 1])
                {
                    maxValue = elements[i - 1];
                }
                for (int o = 0; o < i; o++)
                {
                    str = str.Append(elements[o]);
                }
                for (int p = i - 1; p >= 0; p--)
                {
                    elements.RemoveAt(p);
                }
                Console.WriteLine(str);
                str = new StringBuilder();
                if (elements.Count == 0)
                {

                    for (int r = 0; r < i + 1; r++)
                    {
                        str = str.Append(maxValue);
                    }
                    Console.WriteLine(str);
                    str = new StringBuilder();
                }
            }
        }
        /// <summary>
        /*
         •	Write a function that takes an input like (“abcdefghijklmn”) and print output like that:
            o	a
            o	bc
            o	def
            o	ghij
            o	klmn
             */
        /// </summary>
        static void PrintString()
        {
            string line = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < line.Length + 1; i++)
            {
                for (int p = 0; p < i; p++)
                {
                    str.Append(line[p]);
                }
                for (int d = i - 1; d >= 0; d--)
                {
                    line = line.Remove(d, 1);
                }
                Console.WriteLine(str);
                str = new StringBuilder();
            }
            if (line.Any())
            {
                str.Append(line);
                Console.WriteLine(str);
                str = new StringBuilder();
            }
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        static void ReverseString()
        {
            StringBuilder str = new StringBuilder();
            string line = Console.ReadLine();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                str = str.Append(line[i]);
            }
            Console.WriteLine(str);
            str = new StringBuilder();
        }
        /// <summary>
        /// GetFibonacciIndex series
        /// </summary>
        static void GetFibonacciIndex()
        {
            int index = Convert.ToInt32(Console.ReadLine());
            int[] elements = new int[index];
            elements[0] = 0;
            elements[1] = 1;
            for (int i = 0; i < elements.Length - 2; i++)
            {
                elements[i + 2] = elements[i] + elements[i + 1];
            }
            Console.WriteLine("Final Fibonacci series: " + string.Join(',', elements));
            Console.WriteLine("Fibonacci Index " + index + "= " + elements[index - 1]);
        }
        /// <summary>
        /// Write a function to compute the power of an integer
        /// </summary>
        static void IntergerPower()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = number;
            for (int i = 0; i < power - 1; i++)
            {
                result = result * number;
            }
            Console.WriteLine("Power result= " + result);
        }
        /// <summary>
        /// Write a function to get the min and max of array of integres
        /// </summary>
        static void GetMinMax()
        {
            string line = Console.ReadLine();
            char min = line[0];
            char max = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (Convert.ToInt32(min) > Convert.ToInt32(line[i]))
                {
                    min = line[i];
                }
                if (Convert.ToInt32(max) < Convert.ToInt32(line[i]))
                {
                    max = line[i];
                }
            }
            Console.WriteLine("Max= " + max);
            Console.WriteLine("Min= " + min);
        }
        /// <summary>
        /// Sum list of integers using recursion.
        /// </summary>
        static long result = 0;
        static List<int> elements = new List<int>();
        static void SumRecursion()
        {
            if (elements.Count > 0)
            {
                result += elements[0];
                elements.RemoveAt(0);
                SumRecursion();
            }
            else
            {
                Console.WriteLine(result);
                return;
            }
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= line.Length; i++)
            {
                for (int o = 0; o < i; o++)
                {
                    str.Append(line[o]);
                }
                for (int d = i-1; d >= 0; d--)
                {
                    line.Remove(d);
                }
                Console.WriteLine(str);
                str = new StringBuilder();
            }
            if (line.Any())
            {
                Console.WriteLine(line);
                str = new StringBuilder();
            }

            /*string line = Console.ReadLine();
            elements = line.Split(" ").Select(p => int.Parse(p)).ToList();
            SumRecursion();*/
        }
    }
}
