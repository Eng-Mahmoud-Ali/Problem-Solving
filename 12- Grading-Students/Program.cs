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
            List<int> result = new List<int>();
            foreach (var grade in grades)
            {
                result.Add(grade < 38 || grade % 5 < 3 ? grade : grade + (5 - (grade % 5)));
            }
            return result;
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
