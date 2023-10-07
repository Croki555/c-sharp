using System;

namespace Less5
{
    internal class Program
    {
        //Написать программу, которая упорядочивает элементы массива по убыванию
        public static void Descending(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
        /* Дано трехзначное натуральное число.
        Переставить цифры этого числа так, чтобы получилось максимальное число, записанное этими же цифрами.
        Затем это максимальное число следует возвести в квадрат и вывести */
        public static void MaxNumber(int number)
        {
            string s = number.ToString();
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            Array.Reverse(ch);
            string txt = new string(ch);
            Console.WriteLine($"Максимальное число = {txt}");
            int sqrt = Convert.ToInt32(txt);
            var degree = Math.Pow(sqrt, 2);
            Console.WriteLine($"Квадрат этого числа = {degree}");
        }
        //Написать программу, определяющую номер заданной буквы в алфавите
        public static void LetterNumber(string Letter)
        {
            string Upper = Letter.ToUpper();
            string ABC = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int num = ABC.IndexOf(Upper) + 1;
            Console.WriteLine($"Номер буквы [{Letter}] = {num}");
        }
        /* Написать программу, группирующую элементы массива следующим образом: в начале массива все отрицательные, 
        затем нулевые и в конце все положительные элементы (с сохранением порядка следования в каждой группе */
        public static void Group(int[] numbers)
        {
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
        
        static void Main()
        {
            //1
            Console.WriteLine("№1");
            Console.WriteLine("Массив по убыванию:");
            int[] numbers = { 5, 2, -1, 7, 5, -5, 9, 5, 0, 20, 0 };
            Descending(numbers);
            //2
            Console.WriteLine("№2");
            int number = 473;
            MaxNumber(number);
            //3
            Console.WriteLine("№3");
            LetterNumber("я");
            //4
            Console.WriteLine("№4");
            Group(numbers);
        }
    }
}