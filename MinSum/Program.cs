using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дана целочисленная матрица. Найти минимум из сумм элементов строк

namespace MinSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                matrix[i] = Array.ConvertAll(row.Split(' '), str => int.Parse(str));
            }

            long minSum = matrix[0].Sum();
            foreach (int[] row in matrix)
            {
                long sum = row.Sum();
                if(minSum > sum)
                    minSum = sum;

            }

            Console.WriteLine(minSum);
            Console.ReadKey();

        }
    }
}
