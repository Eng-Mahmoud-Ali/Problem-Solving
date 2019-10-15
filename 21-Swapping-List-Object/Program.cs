using System;
using System.Linq;
using System.Collections.Generic;

namespace _21_Swapping_List_Object
{
    class Program
    {
        private static List<QueueItems> queueItemsList = new List<QueueItems>() {
             new QueueItems(){  Sequence = 1 , Title = 'A'},
                new QueueItems(){  Sequence = 2 , Title = 'B'},
                   new QueueItems(){  Sequence = 3 , Title = 'C'},
                      new QueueItems(){  Sequence = 4 , Title = 'D'},
                         new QueueItems(){  Sequence = 5 , Title = 'E'},
                            new QueueItems(){  Sequence = 6 , Title = 'F'}
        };
        private static List<QueueItems> Swap(int[] convertedItem)
        {
            int oldSequence = convertedItem[0];
            int newSequence = convertedItem[1];
            var moving = queueItemsList.FirstOrDefault(a => a.Sequence == oldSequence);
            if (oldSequence > newSequence)
            {
                foreach (var queue in queueItemsList.Where(p => p.Sequence < oldSequence && p.Sequence >= newSequence))
                {
                    queue.Sequence++;
                }
            }
            else if (oldSequence < newSequence)
            {
                foreach (var queue in queueItemsList.Where(p => p.Sequence > oldSequence && p.Sequence <= newSequence))
                {
                    queue.Sequence--;
                }
            }
            else
            {
                return queueItemsList;
            }
            moving.Sequence = newSequence;
            return queueItemsList.OrderBy(p => p.Sequence).ToList();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Current queue items values\n**************");
            for (int i = 0; i < queueItemsList.Count; i++)
            {
                Console.WriteLine(queueItemsList[i].Sequence + " - " + queueItemsList[i].Title);
            }
            Console.WriteLine("Enter your sequence and new sequence separated by comma\n**************");
            var userInput = Console.ReadLine();
            string[] tokens = userInput.Split(',');
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            //Index  0 = Selected sequence 
            //Index 1 = new sequence to assigned
            var result = Swap(convertedItems);
            //Print values
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].Sequence + " - " + result[i].Title);
            }
        }
    }
    public class QueueItems
    {
        public int Sequence { get; set; }
        public char Title { get; set; }
    }
}
