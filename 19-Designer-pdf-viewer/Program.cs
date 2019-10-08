using System;
using System.Linq;

namespace _19_Designer_pdf_viewer
{
    class Program
    {
        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            // Complete this function
            int temp = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int ascii = (int)word.ElementAt(i);
                int height = h[ascii - 97];
                if (height > temp)
                {
                    temp = height;
                }
            }
            return temp * word.Length;
        }

        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }
    }
}
