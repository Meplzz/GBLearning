using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {

        static void Main(string[] args)
        {
            // 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
            //    В результате вся информация выводится в одну строчку."
            //    Работу на проверку сдал: Дмитрий Дроздов
            //    Прошу прощения, из-за загруженности успел только 2 сделать до 16 часов. Обязаюсь исправиться!

            Console.WriteLine("Задание 1.");
            string Hello = "Привет! Нужно пройти маленький опрос для формирования анкеты\r\n";

            string CheckFirstName = "Введите своё имя:";
            string CheckLastName = "Введите свою фамилию:";
            string CheckUserAge = "Укажите свой возраст:";
            string CheckUserHeight = "Укажите ваш рост:";
            string CheckUserWeight = "Укажите ваш вес:";

            Console.WriteLine(Hello);
            Console.WriteLine(CheckFirstName);
            string FirstName = Console.ReadLine();

            Console.WriteLine(CheckLastName);
            string LastName = Console.ReadLine();

            Console.WriteLine(CheckUserAge);
            string UserAge = Console.ReadLine();

            Console.WriteLine(CheckUserHeight);
            string UserHeight = Console.ReadLine();

            Console.WriteLine(CheckUserWeight);
            string UserWeight = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("1.1 Склеивание");
            Console.WriteLine(FirstName + " " + LastName + ", " + UserAge + ", " + UserHeight + "см" + ", " + UserWeight + "кг\r\n");

            Console.WriteLine("1.2 Форматированный вывод");
            Console.WriteLine("Данные анкеты: {0}, {1}, {2}, {3}см, {4}кг\r\n", FirstName, LastName, UserAge, UserHeight, UserWeight);

            Console.WriteLine("1.3 *используя вывод со знаком $.");
            Console.WriteLine($"{FirstName}, {LastName}, {UserAge}, {UserHeight}см, {UserWeight}кг\r\n");



            // 2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //   где m — масса тела в килограммах, h — рост в метрах
            //   Работу на проверку сдал: Дмитрий Дроздов

            // Используем рост и вес из предыдущего задания:

            NewLine();

            double m = Convert.ToInt32(UserWeight);
            double h = Convert.ToInt32(UserHeight);

            double I = m / (h * h);

            Console.WriteLine($"{FirstName}, Ваш индекс массы тела(ИМТ) равен: {Math.Round(I, 3)}");


            // 3.
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            // по формуле r = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2).Вывести результат, используя спецификатор формата .2f
            // (с двумя знаками после запятой);
            //   Работу на проверку сдал: Дмитрий Дроздов

            NewLine();

            Console.WriteLine("Привет! Программа рассчитает расстояние между двумя точками.");
            Console.WriteLine("Введите ниже координаты первой точки:");
            Console.WriteLine("X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ниже координаты второй точки:");
            Console.WriteLine("X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между двумя точками: {0:F}\r\n", r);

            // б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            //   Работу на проверку сдал: Дмитрий Дроздов

            Console.WriteLine("Вычисления расстояния между точками в виде метода");
            Console.WriteLine("Расстояние между двумя точками: {0:F}", CalculateDist(x1, y1, x2, y2));



            // 4.Написать программу обмена значениями двух переменных.

            //   Работу на проверку сдал: Дмитрий Дроздов

            NewLine();

            // а) с использованием третьей переменной;

            Console.WriteLine("Напишем программу обмена значений между двумя переменными");
            Console.WriteLine("с использованием третьей переменной");
            Console.WriteLine("Имеем две перемененные 'a' = 2 и 'b' = 5, и при помощи переменной 'c' совершим обмен значениями");

            int a = 2;
            int b = 5;
            Console.WriteLine($"а = {a} и b = {b}");
            Console.WriteLine("Вводит третью переменную С и производим обмен.");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Получим результат:");
            Console.WriteLine($"а = {a} и b = {b}");

            //   б) *без использования третьей переменной.
            Console.WriteLine("Напишем программу обмена значений между двумя переменными");
            Console.WriteLine("не использовуя третью переменную");
            Console.WriteLine("Имеем две перемененные 'k' = 12 и 'j' = 15,");

            int k = 12;
            int j = 15;
            Console.WriteLine($"k = {k} и j = {j}");

            (k, j) = (j, k);
            Console.WriteLine($"k = {k} и j = {j}");


            // 5.
            //  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //  б) Сделать задание, только вывод организуйте в центре экрана
            //  в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

            Console.Clear();

            WriteCenter("Вывод инфомации о себе в центре экрана, используя собственный метод.");
            WriteCenter("Дмитрий Дроздов, Москва");



            Console.ReadKey();
        }

        static double CalculateDist(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void NewLine()
        {
            Console.WriteLine("*********\r\n");
        }

        static void WriteCenter(string text)
        {
            // тут нужно переработать
            int width = Console.WindowWidth;
            if (text.Length < width)
            {
                text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');
            }
            // мои добавки для отступа к реальму центру экрана - ловит не размер консоли, а экрана
            int CursorHeight = Console.WindowHeight;
            for (double i = 0; i < CursorHeight / 2; i++)
            {
                Console.WriteLine("\r\n");
            }

            Console.WriteLine(text);
        }


    }
}
