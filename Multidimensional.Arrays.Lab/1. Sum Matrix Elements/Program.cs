using System;
using System.Linq;
using System.Collections.Generic;
namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                    sum += numbers[j];
                }
            }

            Console.WriteLine($"{rows}");
            Console.WriteLine($"{cols}");
            Console.WriteLine($"{sum}");
        }
    }
}
