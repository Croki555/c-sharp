using System;

namespace Calculate2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1:");
            int first = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Введите число 2:");
            int second = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            string oper = Convert.ToString(Console.ReadLine());
            switch (oper) {
                case "+":
                    int summ = first + second;
                    Console.WriteLine("a + b = " + summ);
                    break;
                case "-":
                    int del = first - second;
                    Console.WriteLine("a - b = " + del);
                    break;
                case "*":
                    int umn = first * second;
                    Console.WriteLine("a * b = " + umn);
                    break;
                case "/":
                    int share = first / second;
                    Console.WriteLine("a / b = " + share);
                    break;
                default:
                    Console.WriteLine("Попробуйте еще раз..");
                    break;
            }
        }
    }
}