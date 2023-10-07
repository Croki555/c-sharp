using System;

namespace Notebook
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
            Console.WriteLine($"Имя ученика:{name}");

            Console.WriteLine("Введите возраст:");
            var age = Console.ReadLine();
            Console.WriteLine($"Возраст ученика:{age}");

            Console.WriteLine("Введите балл по русскому языку:");
            var russLang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите балл по математике:");
            var math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите балл по информатике:");
            var info = Convert.ToInt32(Console.ReadLine());

            var result = (russLang + math + info) / 3;
            var score = Convert.ToString(result);
            Console.WriteLine(Convert.ToString($"Средний балл ученика:{score}"));
        }
    }
}