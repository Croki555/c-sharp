using System;
using System.Collections.Generic;

namespace Lesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];// Одномерный массив с типом int и 5 полей
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            Console.WriteLine(numbers[0] + numbers[4]);//сложение 1-го элемента в массиве с 5-м элементом
            string[] seasons = {"Осень", "Зима", "Весна", "Лето"};//создание одномерного массива с типом string
            Console.WriteLine(seasons[0] + " " + seasons[1]);// вывод данных из массива
            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine("Элемент массива numbers = " + numbers[i]);
            }

            List<int> numbers3 = new List<int>();//создания списка
            numbers3.Add(23);
            numbers3.Add(56);
            Console.WriteLine(numbers3[0]);
            numbers3.RemoveAt(0);// удалить 1 элемент в массиве
            Console.WriteLine(numbers3[0]);
        }
    }
}