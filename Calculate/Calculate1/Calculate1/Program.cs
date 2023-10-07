using System;

namespace Calculate1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
            Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
            Console.WriteLine("Нажмите 3 если хотите выполнить умножение");
            Console.WriteLine("Нажмите 4 если хотите выполнить деление");
            Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 5)
            {
                Console.WriteLine("Значение некорректно");
                return;
            } else if  (number == 1)
            {
                Console.WriteLine("Введите слагаемое 1:");
                Console.WriteLine("Введите слагаемое 2:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int summ = a + b;
                Console.WriteLine($"Сумма чисел = {summ}");
            } else if (number == 2)
            {
                Console.WriteLine("Введите уменьшаемое 1:");
                Console.WriteLine("Введите вычитаемое 2:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int del = a - b;
                Console.WriteLine($"Вычитание чисел = {del}");
            } else if (number == 3)
            {
                Console.WriteLine("Введите множитель 1:");
                Console.WriteLine("Введите множитель 2:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int multiply = a * b;
                Console.WriteLine($"Произведение чисел = {multiply}");
            } else if (number == 4)
            {
                Console.WriteLine("Введите делимое 1:");
                Console.WriteLine("Введите делитель 2:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int share = a / b;
                Console.WriteLine($"Деление чисел = {share}");
            } else if (number == 5)
            {
                Console.WriteLine("Введите делимое 1:");
                Console.WriteLine("Введите делитель 2:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int balance = a % b;
                Console.WriteLine($"Остаток от деления чисел = {balance}");
            }
        }
    }
}