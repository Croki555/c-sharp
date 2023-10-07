using System;
using System.Data.Common;
using System.Linq;

namespace Less9
{
    internal class Program
    {
        /* 1. Введите три числа. Возведите в квадрат те из них, значения которых неотрицательны, и в четвертую степень - остальные. */
        private static void Degree()
        {
            Console.Write("Первое число = ");
            double n1 = Double.Parse((Console.ReadLine()));
            Console.Write("Второе число = ");
            double n2 = Double.Parse((Console.ReadLine()));
            Console.Write("Третье число = ");
            double n3 = Double.Parse((Console.ReadLine()));

            char[] first = n1.ToString().ToCharArray();
            char[] second = n2.ToString().ToCharArray();
            char[] three = n3.ToString().ToCharArray();
            
            if (first[0] == '-') { Console.WriteLine(Math.Pow(n1, 4)); }else { Console.WriteLine(Math.Pow(n1, 2)); }
            if (second[0] == '-') { Console.WriteLine(Math.Pow(n2, 4)); }else { Console.WriteLine(Math.Pow(n2, 2)); } 
            if (three[0] == '-') { Console.WriteLine(Math.Pow(n3, 4)); }else { Console.WriteLine(Math.Pow(n3, 2)); } 
        }
        /* 2. Введите координаты двух точек и определите, которая из них ближе к началу координат. */
        private static void Coordinates()
        {
            Console.Write("Первая точка = ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Вторая точка = ");
            int x2 = Int32.Parse(Console.ReadLine());
            if (x1 > x2) { Console.WriteLine($"Точка {x2} ближе к 0"); }else { Console.WriteLine($"Точка {x1} ближе к 0"); }
        }
        /* 3. Введите два угла треугольника (в градусах). Определите, существует ли такой треугольник, и если да, то будет ли он прямоугольным. */
        private static void Triangle()
        {
            Console.Write("Первый угол треугольника (градусы) = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Второй угол треугольника (градусы) = ");
            int b = Int32.Parse(Console.ReadLine());
            int c = 180 - (a + b);
            if (a + b < 180) {
                Console.WriteLine($"Да, существует такой треугольник со стронами {a}, {b}, {c}");
            }
            else
            {
                Console.WriteLine(($"Нет, не существует такой треугольник со стронами {a}, {b}, {c}"));
            }

            if (a == 90 || b == 90 || c == 90)
            {
                Console.WriteLine("Да, он будет прямоугольным");
            }
            
        }
        /* 4. Введите два числа не равные друг другу. Меньшее из них заменить половиной их суммы, а большее - их удвоенным произведением. */
        private static void UnequalNumbers()
        {
            Console.Write("Первое число = ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Второе число = ");
            int n2 = Int32.Parse(Console.ReadLine());
            int sum = (n1 + n2) / 2;
            int dl = 2 * n1 * n2;
            if (n1 > n2)
            {
                n1 = dl;
                Console.WriteLine($"Большее = {n1}");
                n2 = sum;
                Console.WriteLine($"Меньшее = {n2}");
            }
            else
            {
                n1 = sum;
                Console.WriteLine($"Меньшее = {n1}");
                n2 = dl;
                Console.WriteLine($"Большее = {n2}");
            }
        }
        /* 5. Введите координаты точки на плоскости. Определите где она расположена (на какой оси или в каком координатном углу). */
        private static void Plane()
        {
            Console.Write("Ось абсцисс x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Ось ординат y = ");
            double y = Double.Parse(Console.ReadLine());
            if (x > 0 & y > 0) { Console.WriteLine($"Координата ({x};{y}) находится в 1 четверти"); }
            if (x < 0 & y > 0) { Console.WriteLine($"Координата ({x};{y}) находится в 2 четверти"); }
            if (x < 0 & y < 0) { Console.WriteLine($"Координата ({x};{y}) находится в 3 четверти"); }
            if (x > 0 & y < 0) { Console.WriteLine($"Координата ({x};{y}) находится в 4 четверти"); }
        }
        /* 6. Введите дату. Определите её правильность (число от 1 до 31, месяц от 1 до 12). */
        private static void Date()
        {
            Console.WriteLine("Введиите дату:");
            Console.Write("Число = ");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Месяц = ");
            int month = Int32.Parse(Console.ReadLine());
            if (num < 1 || num > 31)
            {
                Console.WriteLine($"Число {num} должно быть в диапозоне от 1 до 31");
            } else if (month < 1 || month > 12)
            {
                Console.WriteLine($"Месяц {month} должен быть в диапозоне от 1 до 12");
            } 
        }
        /* 7. Введите три числа. Найдите сумму большего и меньшего из них. */
        private static void Sum()
        {
            Console.Write("Первое число = ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Второе число = ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.Write("Третье число = ");
            int n3 = Int32.Parse(Console.ReadLine());
            int[] numbers = {n1, n2, n3};
            int min = numbers.Min();
            int max = numbers.Max();
            int sum = min + max;
            Console.WriteLine($"Сумма большего числа и меньшего = {sum}");
        }
        /* 8. Введите координаты точки и радиус окружности. Определите, входит ли точка в окружность (центр окружности в начале координат). */
        private static void Circle()
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = Double.Parse(Console.ReadLine());
            Console.Write("r = ");
            double r = Double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (c < r)
            {
                Console.WriteLine($"Точка ({x};{y}) входит в окружность с радиусом {r}");
            } else 
            {
                Console.WriteLine($"Точка ({x};{y}) не входит в окружность с радиусом {r}");
            }
        }
        /* 9. Введите координаты точки D. Проверьте, принадлежит ли она треугольнику. Координаты вершин треугольника (A, B, C) задайте константами. */
        private static void Peaks()
        {
            //Точка А
            int x1 = 5;
            int y1 = 5;
            //Точка B
            int x2 = 5;
            int y2 = -5;
            //Точка С
            int x3 = -5;
            int y3 = -5;
            //Точка D
            Console.Write("x0 = ");
            int x0 = Int32.Parse(Console.ReadLine());
            Console.Write("y0 = ");
            int y0 = Int32.Parse(Console.ReadLine());
            int a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            int b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            int c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);
            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
            {
                Console.WriteLine("Принадлежит треугольнику");
            }
            else
            {
                Console.WriteLine("Не принадлежит треугольнике");
            }
        }
        /* 10. Введите три числа.
         Определите, можно ли построить треугольник со сторонами, длины которых равны этим числам. 
         Если возможно, то определить, является ли этот треугольник остроугольным.*/
        private static void Sides()
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = Double.Parse(Console.ReadLine());
            double[] abc = {a, b, c};
            if (a < b + c & b < a + c & c < a + b)
            {
                Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} можно построить");
                if (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    Console.WriteLine("Треугольник остроугольный");
                } else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                } else if (Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    Console.WriteLine("Треугольник тупоугольный");
                }
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} нельзя построить");
            }
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("№1");
            //Degree();
            Console.WriteLine("№2");
            //Coordinates();
            Console.WriteLine("№3");
            //Triangle();
            Console.WriteLine("№4");
            //UnequalNumbers();
            Console.WriteLine("№5"); 
            //Plane();
            Console.WriteLine("№6");
            //Date();
            Console.WriteLine("№7");
            //Sum();
            Console.WriteLine("№8");
            //Circle();
            Console.WriteLine("№9");
            //Peaks();
            Console.WriteLine("№10");
            //Sides();
        }
    }
}