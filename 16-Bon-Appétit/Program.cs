using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_Bon_Appétit
{
    class Program
    {
        /// <summary>
        ///  Complete the bonAppetit function below.
        /// </summary>
        /// <param name="bill">the bill menu price items</param>
        /// <param name="k">Refer to that the index item that didn't contribute or eat</param>
        /// <param name="b">the amount that payed</param>
        /// Return the rest of payed amount
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int notSharedItem = bill[k];
            int totalBill = bill.Sum();
            int accurateBill = totalBill - notSharedItem;
            int halfBill = accurateBill / 2;
            int restOfBill = halfBill - b;
            restOfBill = restOfBill >= 0 ? restOfBill : restOfBill * -1;
            Console.WriteLine(restOfBill == 0 ? "Bon Appetit" : restOfBill.ToString());
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
    }
}
