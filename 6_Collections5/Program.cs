//Есть два массива строк. Надо их объединить в одну коллекцию, 
//исключив повторения, не используя Linq. 
//Пример: { "1", "2", "1"} + { "3", "2"} => { "1", "2", "3"}
using System;
using System.Collections.Generic;

namespace _6_Collections5
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> sortNumbers = new();
            
            ExcludeRepetitions(sortNumbers);
        }

        static void ExcludeRepetitions(HashSet<string> sortNumbers)
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
