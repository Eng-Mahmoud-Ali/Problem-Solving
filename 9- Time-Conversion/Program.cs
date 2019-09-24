using System;
using System.Text;

namespace _9__Time_Conversion
{
    class Program
    {
        //Input Format
        //A single string  containing a time in -hour clock format (i.e.:  or )

        /*
       * Complete the timeConversion function below.
       */
        static string timeConversion(string s)
        {
            StringBuilder formatedTime = new StringBuilder();
            string[] dateAttributes = s.Split(':');
            if (dateAttributes[2].Contains("PM"))
            {
                dateAttributes[2] = dateAttributes[2].Replace("PM", "");
                //dayNight = "PM";
                if (dateAttributes[0] == "12")
                {
                    dateAttributes[0] = "00";
                }
                formatedTime = formatedTime.Append(int.Parse(dateAttributes[0]) + 12).Append(":").Append(dateAttributes[1]).Append(":").Append(dateAttributes[2]);
            }
            else
            {
                dateAttributes[2] = dateAttributes[2].Replace("AM", "");
                //dayNight = "AM";
                if (dateAttributes[0] == "12")
                {
                    dateAttributes[0] = "00";
                }
                formatedTime = formatedTime.Append(dateAttributes[0]).Append(":").Append(dateAttributes[1]).Append(":").Append(dateAttributes[2]);
            }

            return formatedTime.ToString();
        }

        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            /*tw.WriteLine(result);
            tw.Flush();
            tw.Close();*/
        }
    }
}
