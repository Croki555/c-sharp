using System;

namespace Lesson2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1) С клавиатуры вводятся два числа – количество забитых голов хозяевами и гостями в футбольном матче. 
            //Вывести на экран результат игры – победили хозяева/гости/ничья.
            Console.WriteLine("Введите колличество голов забитыми хозяевами");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество голов забитыми гостями");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Победили хозяева");
            } else if (a < b)
            {
                Console.WriteLine("Победили гости");
            } else if (a == b)
            {
                Console.WriteLine("Ничья");
            }
            else
            {
                Console.WriteLine("Введены недопустимые символы или тип данных при подсчёте");
            }
            //2) Напишите программу, которая будет проверять число на кратность 3-м и 7-ми (это числа 21, 42, 63...)
            // Вывести на экран соответствующее сообщение.
            Console.WriteLine("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 3 == 0 ? "Число кратно 3 и 7" : "Число не кратно 3 и 7");
        }
    }
}