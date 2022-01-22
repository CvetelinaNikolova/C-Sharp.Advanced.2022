using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                char[] numbers = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            bool haveSymbol = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (matrix[i,j]==symbol)
                    {
                        haveSymbol = true;
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (haveSymbol)
                {
                    break;
                }
            }
            if (haveSymbol)
            {
                Console.WriteLine($"({row}, {col})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
