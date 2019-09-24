using System;
using System.Collections.Generic;
using System.Linq;
namespace Simple_Array_Sum
{
    class Program
    {
        static void calculateElements()
        {
            Console.WriteLine("Please enter the array size numeric value");
            string arraySizeInput = Console.ReadLine();
            //validate array size 
            int arraySize = 0;
            arraySize = int.TryParse(arraySizeInput, out arraySize) ? arraySize : 0;
            if (arraySize <= 0)
            {
                Console.WriteLine("* Array size must be a valid integer number *");
                Console.WriteLine("* Press c to continue *");
                return;
            }
            else
            {
                Console.WriteLine("Please enter array integer elements separated by a space");
                Console.WriteLine("* Note: The non integer elements of the array will be skipped *");
                string arrayElementsStr = Console.ReadLine();
                //Work on the array of elements and validate them
                int n = 0;
                List<string> arrayBeforeValidate = arrayElementsStr.Split(' ').ToList();
                //Select Non empty elements
                arrayBeforeValidate.RemoveAll(p => string.IsNullOrWhiteSpace(p));
                int[] arrayElements = arrayBeforeValidate.Select(p => int.TryParse(p, out n) ? n : 0).ToArray();
                if (arrayElements.Length == arraySize)
                {
                    int result = arrayElements.Sum();
                    Console.WriteLine("* The total result= {0} *", result);
                    Console.WriteLine("* Press c to continue *");
                    return;
                }
                else
                {
                    Console.WriteLine("* The number of numeric elements doesn't match the specified array length *");
                    Console.WriteLine("* Press c to continue *");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {

            calculateElements();
            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.WriteLine("\n");
                calculateElements();
            }
        }
    }
}
