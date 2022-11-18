using System;
using System.Collections.Generic;

namespace _6_Collections5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new();

            StringAddCollection(numbers);

            SortNumbers(numbers);

            EliminationRepetitions(numbers);
        }

        static void StringAddCollection(List<string> numbers)
        {
            string[] listNumbers = new string[] { "50", "30", "10", "20" };
            string[] followingListNumbers = new string[] { "50", "60", "20", "10" };
            numbers.AddRange(listNumbers);
            numbers.AddRange(followingListNumbers);

            Console.Write("Числа: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        static void SortNumbers(List<string> numbers)
        {
            numbers.Sort();

            Console.Write("\nСортировка чисел: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        static void EliminationRepetitions(List<string> numbers)
        {
            HashSet<string> sortNumbers = new(numbers);

            Console.Write("\nИсключение повторений: ");

            foreach (string number in sortNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}