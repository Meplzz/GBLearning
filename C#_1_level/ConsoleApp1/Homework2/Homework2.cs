using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Homework2
    {
        // 1. Написать метод, возвращающий минимальное из трех чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Программа сравнивает 3 числа и выводит минимальное из них");
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Третье первое число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Минимальное число: {MinNumber(a, b, c)}");

            // 2.Написать метод подсчета количества цифр числа.

            Console.WriteLine("Добрый день! Программа выведет количество цифр в числе");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Количество цифр в указанном числе: {DigitalCount(n)}");

            Console.ReadKey();
        }


        public static int MinNumber(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);

        }

        public static int DigitalCount(int n)
        {
            int counter = 0;

            while (n > 0)
            {
                counter++;
                n = n / 10;
            }

            return counter;
        }
    }
}
