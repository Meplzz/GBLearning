using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            string Hello            = "Привет! Нужно пройти маленький опрос для формирования анкеты\r\n";

            string CheckFirstName   = "Введите своё имя:";
            string CheckLastName    = "Введите свою фамилию:";
            string CheckUserAge     = "Укажите свой возраст:"; 
            string CheckUserHeight  = "Укажите ваш рост:";
            string CheckUserWeight  = "Укажите ваш вес:";

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

            Console.WriteLine("*********");

            double m = Convert.ToInt32(UserWeight);
            double h = Convert.ToInt32(UserHeight);

            double I = m / (h * h);

            Console.WriteLine($"{FirstName}, Ваш индекс массы тела(ИМТ) равен: {Math.Round(I, 3)}");

            Console.ReadKey();

        }

        
    }
}
