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

                Console.Write("Введите число от 1 до 9000: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || number > 9000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректное число. Повторите ввод.");
                    Console.ResetColor();
                    Console.Write("Для повторного ввода нажмите любую клавишу.");
                }
                else
                {

                }
                Console.ReadKey();
            }
        }
    }
}
