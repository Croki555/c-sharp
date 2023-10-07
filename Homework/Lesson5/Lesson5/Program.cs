using System;

namespace Lesson5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Вывести на экран 20 элементов последовательности 1, 4, 7, 10, 13...
            for (int i = 1; i < 60; i+= 3)
            {
                Console.WriteLine(i);
            }
            // Напишите программу, которая будет спрашивать правильный пароль,до тех пор, пока он не будет введен. 
            // Правильный пароль пусть будет root.
            var password = "root";
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Введите пароль:");
                var pass = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine("Пароль совпал!");
                    break;
                }
            }
                //Дано два массива одинаковой длины (по 10 элементво). Создайте третий массив, который будет
                //отображать сумму первых двух массивов. Первый элемент третьего массива равен сумме первых
                // массивов и так далее.
                int[] numbers1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                int[] numbers2 = {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
                int[] numbers3 = new int[10];
                for (int j = 0; j < numbers1.Length; j++)
                {
                    numbers3[j] = numbers1[j] + numbers2[j];
                    Console.WriteLine(numbers3[j]);
                }
                Console.ReadKey();
        }
    }
}