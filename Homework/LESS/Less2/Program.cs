using System;
using System.Linq;

namespace Less2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Написать программу, которая переводит время, указанное в секундах, в минуты и секунды. 
            Например:
            Укажите время в секундах: 380
            380 с = 6 мин 20 с
            Укажите время в секундах: 12
            12 с = 0 мин 12 с; */
            
            Console.Write("Укажите время в секундах: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int m = s / 60;
            int sec = s - 60 * m;
            Console.WriteLine($"{s} с = {m} мин {sec} с"); 
            Console.ReadKey(); 
            
            /*Написать программу, которая сообщает, какую сумму денег можно заработать в игре «Кто хочет стать миллионером?»
             за n правильных ответов. 
            Например:
            Введите количество правильных ответов: 12
            За 12 правильных ответов Вы получаете 125000 рублей*/
            
            /* Console.Write("Введите количество правильных ответов: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int money = 0;
            switch (num)
            {
                case 1:
                    money = 1 * 200000;
                    break;
                case 2:
                    money = 2 * 200000;
                    break;
                case 3:
                    money = 3 * 200000;
                    break;
                case 4:
                    money = 4 * 200000;
                    break;
                case 5:
                    money = 5 * 200000;
                    break;
                default:
                    Console.WriteLine("Максимальное количество правильных ответов не может быть больше 5");
                    break;
            }
            Console.WriteLine($"За {num} правильных ответов, вы получаете {money} рублей");
            Console.ReadKey(); */
            
            /* Написать программу, которая определяет, состоят ли два массива из одинаковых элементов (без учета порядка следования).*/
            
            /* int[] numbers1 = {5, 8, 15, 9, 17, 5, 2, 20, 9, 1, 3, 19, 3, 1};
            int[] numbers2 = {1, 19, 1, 6, 12, 13, 19, 20, 4, 4, 15, 1, 18};
            Array.Sort(numbers1);
            int[] newNum1 = numbers1.Distinct().ToArray();
            // 1, 2, 3, 5, 8, 9, 15, 17, 19, 20
            Array.Sort(numbers2);
            int[] newNum2 = numbers2.Distinct().ToArray();
            // 1, 4, 6, 12, 13, 15, 18, 19, 20
            Console.Write("У данных массивов одинаковые элменты - это");
            foreach (var a in newNum1)
            {
                foreach (var b in newNum2)
                {
                    if (a == b)
                    {
                        Console.Write(" " + a);
                    }
                }
            }
            Console.ReadKey(); */
        }
    }
}