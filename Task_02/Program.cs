using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MathOperations math = new MathOperations();

            int sum1 = math.Add(4, 8);
            Console.WriteLine($"Сума чисел: {sum1}");

            int[] array1 = { 3, 5, 1 };
            int[] array2 = { 6, 2, 7 };
            int[] sum2 = math.Add(array1, array2);
            Console.WriteLine($"Сума масивів: [{string.Join(", ", sum2)}]");

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] sum3 = math.Add(matrix1, matrix2);
            Console.WriteLine("Сума матриці:");
            for (int i = 0; i < sum3.GetLength(0); i++)
            {
                for (int j = 0; j < sum3.GetLength(1); j++)
                {
                    Console.Write($"{sum3[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
