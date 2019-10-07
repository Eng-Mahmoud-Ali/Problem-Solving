using System;

namespace _17_Cats_and_Mouse
{
    class Program
    {
        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            int diffY = y - z;
            diffY = diffY > 0 ? diffY : diffY * -1;

            int diffX = x - z;
            diffX = diffX > 0 ? diffX : diffX * -1;

            if (diffX < diffY)
            {
                //Cat A ratches first
                return "Cat A";
            }
            else if (diffX > diffY)
            {
                //Cat B ratches first
                return "Cat B";
            }
            else 
            {
                //Cat reached at the same time 
                return "Mouse C";
            }
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
