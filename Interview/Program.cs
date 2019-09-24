using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Interview
{
    /// <summary>
    /// Base class of clients
    /// </summary>
    interface IClient
    {
        decimal Discount(decimal amount);
    }
    class Client : IClient
    {
        public virtual decimal Discount(decimal amount)
        {
            return amount;
        }
    }
    /// <summary>
    /// Customers with discount 20%
    /// </summary>
    class GoldClient : Client
    {
        public override decimal Discount(decimal amount)
        {
            decimal discount = ((decimal)(((decimal)20 / 100)) * amount);
            return (decimal)(amount - discount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintHierarchy();
            /*Console.WriteLine("Please enter your purchased amount:");
            decimal amountPurchased = Convert.ToDecimal(Console.ReadLine());
            decimal finalAmount = new GoldClient().Discount(amountPurchased);
            Console.WriteLine("Congratulations, your discount is= " + (decimal)(amountPurchased - finalAmount));
            Console.WriteLine("Your gold disacount 20% is active and your amount to pay= " + finalAmount);*/

        }
        static void PrintHierarchy()
        {
            Console.WriteLine("Please enter your input digits:");
            string line = Console.ReadLine();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                for (int p = 0; p <= i; p++)
                {
                    str.Append(" ");
                }
                str.Append(line[i]);
                Console.WriteLine(str);
                str = new StringBuilder();
            }
        }
    }
}
