using System;
using System.Collections.Generic;
using System.Linq;

namespace _12__Grading_Students
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> gradesArr = new List<int>() { 0, 40, 50, 55,60,70, 75, 80, 85, 90, 95, 100 };
            for (int i = 0; i < grades.Count; i++)
            {
                int roundedValue = gradesArr.Where(p => p > grades[i]).FirstOrDefault();
                if (roundedValue - grades[i] < 3)
                {
                    grades[i] = roundedValue;
                }
            }
            return grades;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
