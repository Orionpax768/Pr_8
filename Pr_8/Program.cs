//***************************************************************************
// *Практическая работа №8                                                  *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                 *
//* Задание: Определить кол-во чисел, значение которых >5 по модулю         *
//***************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pr_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "Практическая работа №8";
            bool c = true;
            while (c)
            {
                Console.WriteLine("Здравствуйте!");
                int count = 0;
                string numbers = "";
                int i = 0;
                Console.WriteLine("Введите 10 целых чисел:");
                while (i < 10)
                {
                    try
                    {
                        Console.Write($"Число {i + 1}: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        if (Math.Abs(n) > 5)
                        {
                            count++;
                            if (numbers != " ")
                            {
                                numbers += " ";
                            }
                            numbers += n;
                        }
                        i++;
                    }
                    catch (FormatException fEx)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка:{fEx.Message}");
                        Console.ResetColor();
                    }
                    catch (OverflowException oEx)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка: {oEx.Message}");
                        Console.ResetColor();
                    }
                    catch (Exception ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Произошла ошибка: {ex.Message}");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine($"Количество чисел, больших 5 по модулю: {count}");
                if (count > 0)
                {
                    Console.WriteLine($"Введённые числа: {numbers}");
                }
                else
                {
                    Console.WriteLine("Чисел, больших 5 по модулю, не найдено.");
                }
                Console.WriteLine("Продолжаем? (да/нет)");
                string w = Console.ReadLine();
                switch (w)
                {
                    case "1":
                        Console.WriteLine("Новый расчет:");
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        c = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        Console.WriteLine("Нажмите любую клавишу для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Программа завершена, нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
