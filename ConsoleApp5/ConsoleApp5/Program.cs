using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания:");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");


            int lol = int.Parse(Console.ReadLine());

            switch (lol)
            {
                case 1:
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num > 0)
                    {
                        num += 5;
                    }
                    else if (num < 0)
                    {
                        num -= 5;
                    }

                    Console.WriteLine($"Результат: {num}");
                    break;

                case 2:
                    Console.Write("Введите число 1: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Введите число 2: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("Введите число 3: ");
                    int c = int.Parse(Console.ReadLine());

                    int max = a;

                    if (b > max)
                    {
                        max = b;
                    }

                    if (c > max)
                    {
                        max = c;
                    }

                    Console.WriteLine("Наибольшее число - " + max);
                    break;

                case 3:
                    Console.Write("Введите число 1: ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Введите число 2: ");
                    int y = int.Parse(Console.ReadLine());

                    Console.Write("Введите число 3: ");
                    int z = int.Parse(Console.ReadLine());

                    int sum = 0;

                    if (x > 0)
                    {
                        sum += x;
                    }

                    if (y > 0)
                    {
                        sum += y;
                    }

                    if (z > 0)
                    {
                        sum += z;
                    }

                    Console.WriteLine("Сумма положительных чисел - " + sum);
                    break;

                case 4:

                    Console.Write("Введите число: ");
                    int x1 = int.Parse(Console.ReadLine());

                    if (x1 > 10)
                    {
                        x1 *= 2;
                    }

                    Console.WriteLine($"Результат: {x1}");

                    Console.ReadKey();

                    break;

                case 5:

                    Console.WriteLine("Введите число в диапвазоне от 1 до 7");
                    Console.WriteLine("1 - понедельник");
                    Console.WriteLine("2 - вторник");
                    Console.WriteLine("3 - среда");
                    Console.WriteLine("4 - четверг");
                    Console.WriteLine("5 - пятница");
                    Console.WriteLine("6 - суббота");
                    Console.WriteLine("7 - воскресенье");

                    int x2 = int.Parse(Console.ReadLine());

                    if (x2 == 1)
                    {
                        Console.WriteLine("Понедельник");
                    }
                    if (x2 == 2)
                    {
                        Console.WriteLine("Вторник");
                    }
                    if (x2 == 3)
                    {
                        Console.WriteLine("Среда");
                    }
                    if (x2 == 4)
                    {
                        Console.WriteLine("Четверг");
                    }
                    if (x2 == 5)
                    {
                        Console.WriteLine("Пятница");
                    }
                    if (x2 == 6)
                    {
                        Console.WriteLine("Суббота");
                    }
                    if (x2 == 7)
                    {
                        Console.WriteLine("Воскресенье");
                    }
                    Console.WriteLine("Введенное число не входит в диапазон от 1 до 7");
                    break;

                case 6:
                    int num2 = 200;

                    while (num2 % 17 != 0)
                    {
                        num2++;
                    }
                    Console.WriteLine(num2);
                    break;


                        case 7:
                    double p  = 10.0;
                    double p1 = 10.0;
                    int day = 1;

                    while (p < 20.0)
                    {
                        p *= 1.05;
                        p1 += p;
                        day++;
                    }

                    Console.WriteLine("Человек пробежит 20км на " + day + " день.");

                    while (p1 < 100.0)
                    {
                        p *= 1.05;
                        p1 += p;
                        day++;
                    }

                    Console.WriteLine("Сумма пробега будет больше 100км на " + day + " день.");
                    break;

                case 8:

                    Console.Write("Введите число: ");
                    int num3 = int.Parse(Console.ReadLine());

                    int factorial = 1;

                    for (int i = 2; i <= num3; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine("Факториал числа " + num3 + " равен " + factorial);
                    break;


                    case 9:
                    Console.Write("Введите число: ");
                    int num4 = int.Parse(Console.ReadLine());

                    int divisor = 2;

                    while (num4 % divisor != 0)
                    {
                        divisor++;
                    }

                    Console.WriteLine("Наименьший делитель числа " + num4 + ", отличный от 1: " + divisor);
                    break;

                default:
                    Console.WriteLine("Некорректный выбор действия!");
                    break;
            }
            Console.ReadKey();
        }
    }
}