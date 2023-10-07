using System;

namespace Less8
{
    internal class Program
    {
        //Дано натуральное число. Определить, сколько раз в нем встречается первая цифра.
        private static void CountNumOne()
        {
            Console.Write("Введите натуральное число = ");
            int number = Convert.ToInt32(Console.ReadLine());
            char[] num = number.ToString().ToCharArray();
            int count = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (num[0] == num[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"В числе ({number}) первое число({num[0]}) встречается {count} раз");
        }
        /* Дано натуральное число.
           а) Определить его максимальную и минимальную цифры.
           б) Определить, на сколько его максимальная цифра превышает минимальную.
           в) Найти сумму его максимальной и минимальной цифр.*/
        static int GetMax(int number)
        {
            char[] maxNum = number.ToString().ToCharArray();
            Array.Sort(maxNum);
            var max =Convert.ToInt32(maxNum[number.ToString().Length - 1].ToString()) ;
            return max;
        }
        static int GetMin(int number)
        {
            char[] minNum = number.ToString().ToCharArray();
            Array.Sort(minNum);
            Array.Reverse(minNum);
            var max =Convert.ToInt32(minNum[number.ToString().Length - 1].ToString()) ;
            return max;
        }
        /* Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:
        а) в какой день он пробежит больше 20 км;
        б) в какой день суммарный пробег за все дни превысит 100км*/
        private static void Skier()
        {
            Console.WriteLine("Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:");
            Console.WriteLine("а) в какой день он пробежит больше 20 км;");
            Console.WriteLine("б) в какой день суммарный пробег за все дни превысит 100 км");
            int s = 10;//км
            int day = 1;
            for (int i = 0; s < 20; i++)
            {
                day++;
                s++;
            }
            //11 день это 21км
            Console.WriteLine($"В {day} день он пробежит больше {s} км");
            for (int i = 0; s < 100; i++)
            {
                day++;
                s++;
            }
            Console.WriteLine($"В {day} день он пробежит больше 100 км");
        } 
        public static void Main(string[] args)
        {
            //1
            Console.WriteLine("№1"); 
            CountNumOne();
           
            //2
            Console.WriteLine("№2");
            Console.Write("Введите натуральное число = ");
            int number = Int32.Parse(Console.ReadLine());
            int max = GetMax(number);
            int min = GetMin(number);
            Console.WriteLine($"Максимальная цифра {max}, а минимальная {min}");
            Console.WriteLine($"Максимальная цифра превышает минимальную на {max-min}");
            Console.WriteLine($"Сумма максимальной и минимальной цифры = {max+min}"); 
            //3
            Console.WriteLine("№3");
            
            //4
            Console.WriteLine("№4");
            Skier();
            Console.ReadKey();
        }
    }
}