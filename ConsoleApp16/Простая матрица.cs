using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Введите размерность матрицы:
Количество строк: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[row, col];
            double[] average = new double[row];

            Random rnd = new Random();
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{$"{row + 1}|",4}");
                Console.ResetColor();
                double sum = 0;
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rnd.Next(1, 100);
                    Console.Write($"{$"{matrix[row, col]}", 4}");
                    sum += matrix[row, col];
                }
                average[row] = (double)sum / col;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{$"|",4}");
            string line = new string('_', 4 * col);
            Console.WriteLine(line);
            Console.Write($"{$" ",4}");
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{$"{col + 1}",4}");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"Строка {i + 1}, среднее арифметическое: {average[i].ToString("0.00")}");
            }
            Console.ReadKey();
        }
    }
}
