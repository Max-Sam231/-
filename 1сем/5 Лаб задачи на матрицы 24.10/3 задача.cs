using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // минимальный в строке максимальный в столбце
            int n = 1, m = 1, elem;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int[] rowArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    elem = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = elem;
                }
            }
            // Вывод
            Console.WriteLine("Иcходная матрица");
            for (int i = 0; i < n; i++) // Цикл по строкам
            {
                for (int j = 0; j < m; j++) // Цикл по столбцам
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] minRow = new int[n];
            for (int i = 0; i < n; i++) { minRow[i] = 1000; }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    minRow[i] = Math.Min(matrix[i, j], minRow[i]);
                }
            }
            int[] maxCol = new int[m];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    maxCol[j] = Math.Max(matrix[i, j], maxCol[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == maxCol[j] && matrix[i, j] == minRow[i])
                    { Console.WriteLine(matrix[i, j]); }
                }
            }
        }
    }
}

