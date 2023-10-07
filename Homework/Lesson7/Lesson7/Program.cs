using System;

namespace Lesson7
{
    internal class Program
    {
        public static void ReplaceName(int[] numbers, int number, int newNumber)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                        numbers[i] = newNumber * -1;
                }
            }
        public static int GetMin(int[] numbers2)
        {
            int min = numbers2[0];
            for (int i = 1; i < numbers2.Length; i++)
            {
                if (numbers2[i] < min)
                {
                    min = numbers2[i];
                }
            }
            return min;
        }
        public static int Fibbonachi(int index)
        {
            //1,1,2,3,5,8
            int first = 1;
            int second = 1;
            if (index == 1 | index == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 3; i <= index; i++)
                {
                    second = first + second;
                    first = second - first;
                }
                return second;
            }
            // 1, 1, 2, 3, 5, 8, 11, 19
        }
        static void Main()
            {
                int[] numbers = { 5, 2, 7, 5, -5, 9, 5 };
                ReplaceName(numbers, 5, 5); 
                for (int d = 0; d < numbers.Length; d++)
                {
                    Console.WriteLine(numbers[d]);
                }
                //////
                int[] numbers2 = {10, 20, 5, 15, 9};
                int min;
                min = GetMin(numbers2);
                Console.WriteLine("Минимальное число = " + GetMin(numbers2));
                
                //////
                Console.Write("Задайте порядковый номер числа Фиббоначи = ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число Фиббоначи = " + Fibbonachi(index));
            }
    }
}