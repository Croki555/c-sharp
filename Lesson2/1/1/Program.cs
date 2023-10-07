using System;

namespace _1
{
    /*Задание 1:
    Выполнить: Попросите пользователя ввести число. Проверьте, является ли введенное число положительным или оно является отрицательным. 
    Выведите результат.
    */
    /*Задание 2:
Выполнить: Дано двухзначное число. Вывести отдельно его десятичный разряд и разряд единиц (операторы %, /).
  состоит из цифр 5 и6, но не -5 и -6. Чтобы вывести модуль числа:
*/
    class Program
    {
        static void Ex1()
        {
            Console.Write("Введите число = ");
            int num = Int32.Parse(Console.ReadLine());
            string str = (num.ToString().Contains("-")) ? "Введённое число отрицательное" : "Введённое число положительное";
            Console.WriteLine($"Результат: {str}");
        }
        static void Ex2()
        {
            Console.Write("Введите число ");
            int num = Int32.Parse(Console.ReadLine());
            string str = (num.ToString().Contains("-")) ? $"единицы {num.ToString()[2]} десятки {num.ToString()[1]}" : $"единицы {num.ToString()[1]} десятки {num.ToString()[0]}";
            Console.WriteLine($"Результат: {str}");
        }
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
        }
    }
}
