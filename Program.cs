using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    internal class Program
    {
        static void Exemple01()
        {
            Console.WriteLine("Введите текст. Для завершения введите точку.");
            int spaceCount = 0;
            while (true)
            {
                char input = Console.ReadKey().KeyChar;
                if (input == '.')
                    break;
                if (input == ' ')
                    spaceCount++;
            }

            Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
        }
        static void Exemple02()
        {
            Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
            string ticketNumber = Console.ReadLine();

            if (ticketNumber.Length != 6)
            {
                Console.WriteLine("Неверный формат номера билета.");
                return;
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum1 += int.Parse(ticketNumber[i].ToString());
                sum2 += int.Parse(ticketNumber[i + 3].ToString());
            }

            if (sum1 == sum2)
                Console.WriteLine("Этот билет счастливый!");
            else
                Console.WriteLine("Этот билет несчастливый.");
        }
        static string ConvertCase(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
                else if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
            }
            return new string(chars);
        }
        static void Exemple03()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
            string result = ConvertCase(input);
            Console.WriteLine("Результат: " + result);
        }
        static int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            return reversed;
        }
        static void Exemple04()
        {
            Console.WriteLine("Введите целое число N:");
            int N = int.Parse(Console.ReadLine());

            int reversedN = ReverseNumber(N);
            Console.WriteLine("Число, прочитанное справа налево: " + reversedN);
        }
        static void Exemple05()
        {
            int a = 5;
            int b = 10;
            int c = 21;

            Console.WriteLine($"{a}  {b}  {c}");
        }
        static void Exemple06()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        static void Exemple07()
        {
            Console.WriteLine("Введите расстояние в сантиметрах:");
            int centimeters = int.Parse(Console.ReadLine());

            int meters = centimeters / 100;
            Console.WriteLine("Полных метров: " + meters);
        }
        static void Exemple08()
        {
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("Полных недель: " + weeks);
        }
        static void Exemple09()
        {
            double resistance1 = 10.0;
            double voltage1 = 12.0;

            double resistance2 = 15.0;
            double voltage2 = 10.0;

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток протекает по первому участку.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток протекает по второму участку.");
            }
            else
            {
                Console.WriteLine("Токи равны на обоих участках.");
            }
        }
        static void Exemple10()
        {
            double volume1 = 1000;
            double mass1 = 500;

            double volume2 = 800;
            double mass2 = 400;

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Плотность первого тела больше.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Плотность второго тела больше.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }
        static void Exemple11()
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("Значение функции y = " + y);
        }
        static void Exemple12()
        {
            Console.WriteLine("Введите значение a:");
            double a = double.Parse(Console.ReadLine());

            double x = 12 * a * a + 7 * a - 16;
            Console.WriteLine("Значение функции x = " + x);
        }
        static void Exemple13()
        {
            Console.WriteLine("Введите длину стороны квадрата:");
            double sideLength = double.Parse(Console.ReadLine());

            double perimeter = 4 * sideLength;
            Console.WriteLine("Периметр квадрата: " + perimeter);
        }
        static void Exemple14()
        {
            Console.WriteLine("Введите радиус окружности:");
            double radius = double.Parse(Console.ReadLine());

            double diameter = 2 * radius;
            Console.WriteLine("Диаметр окружности: " + diameter);
        }
        static void Exemple15()
        {
            double R = 6350; // Радиус Земли в километрах

            Console.WriteLine("Введите высоту над Землей (в километрах):");
            double height = double.Parse(Console.ReadLine());

            double distanceToHorizon = Math.Sqrt((R + height) * (R + height) - R * R);
            Console.WriteLine("Расстояние до линии горизонта: " + distanceToHorizon + " км");
        }
        static void Main(string[] args)
        {
            Exemple01();
            Exemple02();
            Exemple03();
            Exemple04();
            Exemple05();
            Exemple06();
            Exemple07();
            Exemple08();
            Exemple09();
            Exemple10();
            Exemple11();
            Exemple12();
            Exemple13();
            Exemple14();
            Exemple15();

            Console.ReadKey();
        }
    }
}