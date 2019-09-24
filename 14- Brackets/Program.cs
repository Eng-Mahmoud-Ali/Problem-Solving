using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _14__Brackets
{
    /// <summary>
    /// To validate brackets if valid or not, must be all brackets closed
    /// ()()(()) Valid
    /// ()(()))( InValid
    /// </summary> 
    class Program
    {
        static void Main(string[] args)
        {
            string brakets = Console.ReadLine();

            var resultPop = ValidateByPop(brakets);
            var resultIndex = ValidateByIndex(brakets);
            Console.WriteLine(resultPop ? " Stack-Pop-Push - ** String brakets is VALID ** " : "Stack-Pop-Push - !! String brakets is invalid");
            Console.WriteLine(resultIndex ? " Stack-Compare-Index - ** String brakets is VALID ** " : "Stack-Compare-Index - !! String brakets is invalid");

        }
        /// <summary>
        /// Validate by Pop and push from the array
        /// </summary>
        /// <param name="brakets"></param>
        /// <returns></returns>
        static bool ValidateByPop(string brakets)
        {
            int countClosed = brakets.Count(o => o == ')');
            int countOpened = brakets.Count(o => o == '(');
            if (countClosed != countOpened)
            {
                return false;
            }
            while (brakets.Any())
            {
                if (brakets[0] == ')')
                {
                    return false;
                }
                else
                {
                    for (int o = 1; o < brakets.Length; o++)
                    {
                        if (brakets[o] == ')')
                        {
                            brakets = brakets.Remove(o, 1);
                            brakets = brakets.Remove(0, 1);
                            break;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Validate by comparing the index value of open < close
        /// </summary>
        /// <param name="brakets"></param>
        /// <returns></returns>
        static bool ValidateByIndex(string brakets)
        {
            Stack<int> openBraketsArr = new Stack<int>();
            Stack<int> CloseBraketsArr = new Stack<int>();

            for (int i = 0; i < brakets.Length; i++)
            {
                if (brakets[i] == '(')
                {
                    openBraketsArr.Push(i);
                }
                else
                {
                    CloseBraketsArr.Push(i);
                }
            }
            if (openBraketsArr.Count != CloseBraketsArr.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < openBraketsArr.Count; i++)
                {
                    if (openBraketsArr.ElementAt(i) > CloseBraketsArr.ElementAt(i))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
