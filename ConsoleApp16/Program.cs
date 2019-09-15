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
            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество квадратов: ");
                int numSquare = Convert.ToInt32(Console.ReadLine());

                if (numSquare < 2 || numSquare > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректное число. Повторите ввод.");
                    Console.ResetColor();
                    Console.Write("Для повторного ввода нажмите любую клавишу.");
                }
                else
                {
                    int x = 1;
                    int y = 2;

                    Console.SetCursorPosition(x, y);
                    ConsoleColor color;

                    for (; numSquare >= 0; numSquare--)
                    {
                        for (int j = 1; j <= numSquare * 2 + 2; j++)
                        {
                            color = (ConsoleColor)10 - numSquare;
                            Console.ForegroundColor = color;
                            for (int k = 1; k <= numSquare * 2 + 2; k++)
                            {
                                Console.Write($"{numSquare}");
                            }
                            Console.WriteLine();
                            Console.SetCursorPosition(x, y + j);
                            Console.ResetColor();
                        }
                        Console.SetCursorPosition(++x, ++y);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
