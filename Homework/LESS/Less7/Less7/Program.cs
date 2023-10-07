using System;

namespace Less7
{
    internal class Program
    {
        //Пользователь вводит площади нескольких кругов. Найти радиус самого маленького из них
        public static void GetMinR()
        {
            Console.WriteLine("Введите 3 площади круга:");
            Console.Write("Площадь 1 круга = ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            double r1 = (Math.Sqrt(Convert.ToInt32(s1) / Math.PI));
            Console.Write("Площадь 2 круга = ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            double r2 = (Math.Sqrt(Convert.ToInt32(s2) / Math.PI));
            Console.Write("Площадь 3 круга = ");
            double s3 = Convert.ToDouble(Console.ReadLine());
            double r3 = (Math.Sqrt(Convert.ToInt32(s3) / Math.PI));
            double min = 0;
            if (r1 > r2)
            {
                min = r2;
                if (r3 < min)
                {
                    min = r3;
                    Console.WriteLine($"Площадь маленькго круга = {min}");
                }
                else
                {
                    Console.WriteLine($"Площадь маленькго круга = {(min)}");
                }
            } else
            {
                min = r1;
                if (r3 < min)
                {
                    min = r3;
                    Console.WriteLine($"Площадь маленькго круга = {min}");
                }
                else
                {
                    Console.WriteLine($"Площадь маленькго круга = {min}");
                }
            }
        }
        //Пользователь вводит площади нескольких квадратов. Найти длину диагонали самого большого из них
        public static void GetMaxL()
        {
            Console.WriteLine("Введите 3 площади квадрата:");
            Console.Write("Площадь 1 квадрата = ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            double l1 = Math.Sqrt(2 * Convert.ToDouble(s1));
            Console.Write("Площадь 2 квадрата = ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            double l2 = Math.Sqrt(2 * Convert.ToDouble(s2));
            Console.Write("Площадь 3 квадрата = ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            double l3 = Math.Sqrt(2 * Convert.ToDouble(s3));
            var max = 0;
            if (l1 > l2)
            {
                max = Convert.ToInt32(l1);
                if (max > l3)
                {
                    Console.WriteLine($"Большая длина диагонали квадрата = {max}");
                }
                else
                {
                    max = Convert.ToInt32(l3);
                    Console.WriteLine($"Большая длина диагонали квадрата = {max}");
                }
            }
            else
            {
                max = Convert.ToInt32(l2);
                if (max > l3)
                {
                    Console.WriteLine($"Большая длина диагонали квадрата = {max}");
                }
                else
                {
                    max = Convert.ToInt32(l3);
                    Console.WriteLine($"Большая длина диагонали квадрата = {max}");
                }
            }
        }
        /* Пользователь вводит кол-во игр.
         В чемпионате по футболу команде за выигрыш дается 3 очка, за проигрыш — 0, за ничью — 1. Известно число очков, 
        полученных командой за каждую из проведенных игр. Определить количество выигрышей, количество проигрышей и количество ничьих.(switch-case)*/
        public static void Match()
        {
            Console.Write("Количество игр = "); // 5
            int numGames = Convert.ToInt32(Console.ReadLine());
            
            int Win = 3;
            int pointWin = 0;
            
            int Lose = 0;
            int pointLose = 0;
            
            int Draw = 1;
            int pointDraw = 0;
            
            for (int i = 0; i < numGames; i++)
            {
                Console.Write($"{i+1} игра очков = ");
                int point = Convert.ToInt32(Console.ReadLine());
                if (point == Win) {pointWin++;point+= point; }
                if (point == Lose) { pointLose++; }
                if (point == Draw) { pointDraw++; }
            }
            Console.WriteLine($"Побед {pointWin} Поражений {pointLose} Ничья {pointDraw}");
        }
        //Пользователь вводит натуральное число. Верно ли, что цифра a встречается в нем реже, чем цифра b?
        public static void NatNum()
        {
            Console.Write("Введите натурально число = ");
            int number = Convert.ToInt32(Console.ReadLine());
            char[] num = number.ToString().ToCharArray();
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            char[] numA = a.ToString().ToCharArray();
            int numsA = 0;
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            char[] numB = b.ToString().ToCharArray();
            int numsB = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                if (numA[0] == num[i]) { numsA++; }
                if (numB[0] == num[i]) { numsB++; }
            }
            Console.WriteLine("Верно ли, что цифра a встречается в нем реже, чем цифра b?");
            if (numsA < numsB)
            {
                Console.WriteLine($"Да, число а встречается реже чем число b");
            }
            else
            {
                Console.WriteLine($"Нет, число а не встречается реже чем b");
            }
        }
        public static void Main(string[] args)
        {
            //1
            Console.WriteLine("№1");
            GetMinR();
            //2
            Console.WriteLine("№2");
            GetMaxL();
            //3
            Console.WriteLine("№3");
            Match();
            //4
            Console.WriteLine("№4");
            NatNum();
        }
    }
}