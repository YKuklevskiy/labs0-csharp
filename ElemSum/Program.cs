using System;
using System.Linq;

// Напишите программу, находящую и выводящую сумму всех элементов строки, максимальный элемент строки и его индекс.

namespace ElemSum
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int count = input.Split(' ').Length;
            int[] numbers = Array.ConvertAll(input.Split(' '), str => int.Parse(str));
            long sum = numbers.Sum();
            int max = numbers.Max();
            int maxIndex = Array.IndexOf(numbers, max);

            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(maxIndex);
            Console.ReadKey();

        }
    }
}
