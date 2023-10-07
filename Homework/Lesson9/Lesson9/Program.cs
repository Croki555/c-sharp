using System;

namespace Lesson9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
            Console.WriteLine("Введите 2 порядковых номера в массиве numbers");
            try
            {
                int first = Convert.ToInt32(Console.ReadLine());
                int second = Convert.ToInt32(Console.ReadLine());
                var result2 = numbers[first] + numbers[second];
                Console.WriteLine($"Порядковый номер {first} = " + numbers[first]);
                Console.WriteLine($"Порядковый номер {second} = " + numbers[second]);
                Console.WriteLine("Сумма этих чисел = " + result2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Вы ввели не число или ничего не ввели");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Номер элемента должен быть в диапозона от 0 до " + (numbers.Length - 1));
            }
        }
    }
}