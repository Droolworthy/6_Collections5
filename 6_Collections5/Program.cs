using System;
using System.Collections.Generic;

namespace _6_Collections5
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> sortNumbers = new();
            
            EliminateRepetition(sortNumbers);
        }

        static void EliminateRepetition(HashSet<string> sortNumbers)
        {
            string[] listNumbers = new string[] { "50", "30", "10", "20" };
            string[] followingListNumbers = new string[] { "50", "60", "20", "10" };
            sortNumbers.UnionWith(listNumbers);
            sortNumbers.UnionWith(followingListNumbers);

            Console.Write("Исключение повторений: ");

            foreach (string number in sortNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
