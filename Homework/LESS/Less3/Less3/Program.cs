using System;

namespace Less3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {1, 3, 8, 10, 11, 15, 1, 2, 6};
            int even = 0; //четные
            int add = 0; //нечетные
            foreach (int result in numbers)
            {
                if (result % 2 == 0) {even++;}
                if (result % 2 != 0) {add++;}
            }
            Console.WriteLine($"Четных чисел в массиве numbers = {even}");
            Console.WriteLine($"Нечетных чисел в массиве numbers = {add}");
        }
    }
}