using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            /*
            Console.WriteLine("Введите число от 1 до 100:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 100.");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
            */


            //Задание 2

            /*
            Console.WriteLine("Введите первое число:");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент:");
            double percent = double.Parse(Console.ReadLine());

            double result = number * (percent / 100);

            Console.WriteLine("Результат: " + result);
            */


            //Задание 3

            /*
            Console.WriteLine("Введите четыре цифры:");

            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int digit3 = int.Parse(Console.ReadLine());
            int digit4 = int.Parse(Console.ReadLine());

            int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine("Сформированное число: " + number);

            */


            //Задание 4

            /*
            Console.WriteLine("Введите шестизначное число:");
            string numberStr = Console.ReadLine();

            if (numberStr.Length != 6)
            {
                Console.WriteLine("Ошибка! Число должно быть шестизначным.");
                Console.ReadKey();
                return;
            }

            int number = int.Parse(numberStr);

            Console.WriteLine("Введите номера разрядов для обмена цифр:");
            int pos1 = int.Parse(Console.ReadLine());
            int pos2 = int.Parse(Console.ReadLine());

            int num1 = GetDigitAtPosition(number, pos1);
            int num2 = GetDigitAtPosition(number, pos2);

            number = SwapDigitsAtPositions(number, pos1, pos2, num1, num2);

            Console.WriteLine("Результат: " + number);

            Console.ReadKey();
        }

        static int GetDigitAtPosition(int number, int position)
        {
            int digit = 0;

            for (int i = 0; i < position; i++)
            {
                digit = number % 10;
                number /= 10;
            }

            return digit;
        }

        static int SwapDigitsAtPositions(int number, int pos1, int pos2, int num1, int num2)
        {
            int newNumber = 0;
            int factor = 1;

            for (int i = 0; i < pos1; i++)
            {
                int digit = number % 10;

                newNumber += digit * factor;
                factor *= 10;

                number /= 10;
            }

            newNumber += num2 * factor;
            factor *= 10;

            number /= 10;

            for (int i = pos1 + 1; i < pos2; i++)
            {
                int digit = number % 10;

                newNumber += digit * factor;
                factor *= 10;

                number /= 10;
            }

            newNumber += num1 * factor;
            factor *= 10;

            number /= 10;

            while (number > 0)
            {
                int digit = number % 10;

                newNumber += digit * factor;
                factor *= 10;

                number /= 10;
            }

            return newNumber;

            */


            //Задание 5

            /*
            Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
            string input = Console.ReadLine();

            DateTime date;

            if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                string season = GetSeason(date);
                string dayOfWeek = date.ToString("dddd");

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Ошибка! Некорректный формат даты.");
            }

            Console.ReadKey();
        }

        static string GetSeason(DateTime date)
        {
            int month = date.Month;

            if (month == 12 || month <= 2)
            {
                return "Winter";
            }
            else if (month >= 3 && month <= 5)
            {
                return "Spring";
            }
            else if (month >= 6 && month <= 8)
            {
                return "Summer";
            }
            else
            {
                return "Autumn";
            }

            */


            //Задание 6

            /*
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Перевести из Фаренгейта в Цельсий");
            Console.WriteLine("2 - Перевести из Цельсия в Фаренгейт");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите температуру:");
            double temperature = double.Parse(Console.ReadLine());

            double convertedTemperature = 0;

            if (choice == 1)
            {
                convertedTemperature = FahrenheitToCelsius(temperature);
                Console.WriteLine($"Температура в Цельсиях: {convertedTemperature} °C");
            }
            else if (choice == 2)
            {
                convertedTemperature = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"Температура в Фаренгейтах: {convertedTemperature} °F");
            }
            else
            {
                Console.WriteLine("Ошибка! Некорректный выбор.");
            }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

            */


            //Задание 7


            /*
            Console.WriteLine("Введите два числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            Console.WriteLine("Четные числа в указанном диапазоне:");

            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            Console.ReadKey();
        }
    }
}
