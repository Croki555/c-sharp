using System;

namespace Less6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). 
            // Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.
            
            Console.Write($"Задайте сколько будет действительных чисел в массиве = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Задайте диапозон рандомных этих чисел:");
            Console.Write($"От: ");
            int minus = Convert.ToInt32(Console.ReadLine());
            Console.Write($"До: ");
            int plus = Convert.ToInt32(Console.ReadLine());
            Random x = new Random();
            int[] numbers = new int[N];
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = x.Next(minus,plus);
                Console.WriteLine($"Число в массиве = {numbers[i]}");
                if (numbers[i] <= 10 & numbers[i] >= -10)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество элементво в диапазоне от -10 до 10 = {count}"); 
            
            //В двухмерном массиве переставьте попарно соседние строки, т.е. 1-ю со 2-ой, 3-ю с 4-й и т.д. Результат выведите на экран
            
            /* int[,] numbers = new int[4, 3] { { 0, 1, 2 }, { 3, 4, 5 }, {6, 7, 8}, {9, 10, 11} };
            Console.WriteLine("Изначальный двухмерный массив");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }

            for (int a = 0; a < numbers.GetLength(1); a++)
            {
                int first = numbers[1, a];//3
                numbers[1, a] = numbers[0, a]; // 3 = 0
                numbers[0, a] = first; // 0 = first т.е 3
            }
            for (int e = 0; e < numbers.GetLength(1); e++)
            {
                int last = numbers[3, e];
                numbers[3, e] = numbers[2, e];
                numbers[2, e] = last;
            }
            Console.WriteLine("Готовый результат");
            for (int с = 0; с < numbers.GetLength(0); с++)
            {
                for (int d = 0; d < numbers.GetLength(1); d++)
                {
                    Console.Write($"{numbers[с, d]}\t");
                }
                Console.WriteLine();
            } */
            
            //Пользователь вводит произвольный текст. Найти сумму всех имеющихся в нем чисел.
            
            /* Console.Write("Введите текст с цифрами: ");
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i]))
                {
                    string a = Convert.ToString(text[i]);
                    int b = Convert.ToInt32(a);
                    sum += b;
                }
            }
            Console.WriteLine($"Сумма цифр в тексте = {sum}"); */
        }
    }
}