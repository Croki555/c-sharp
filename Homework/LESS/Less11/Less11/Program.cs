using System;
using System.Linq;

namespace Less11
{
    internal class Program
    {
        public static void Fibbonachi(int index)
        {
            //1,1,2,3,5,8
            int first = 1;
            int second = 1;
            if (index == 1)
            {
                Console.WriteLine(first);
            } else if (index == 2)
            {
                Console.Write($"{first}   {second}");
            } else if (index > 2)
            {
                Console.Write($"{first}   {second}   ");
                for (int i = 3; i <= index; i++)
                {
                    first = first + second;
                    Console.Write($"{first}   ");
                    second = first + second;
                }
            }
        }
        public static void Main(string[] args)
        {
            //Найдите наибольшее число в массиве (массив инициализировать случайными значениями)
            
            /*var numbers = new int[10];
            int sum = 0;
            int mult = 1;
            int even = 0; //четные
            int odd = 0; //нечётные
            int fact = 1;
            
            Random rand = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0,10);
                if (numbers[i] % 2 == 0) { even++; }else { odd++; }
                sum += numbers[i];
                mult *= numbers[i];
            }
            string s = string.Join(",", numbers);
            Console.WriteLine(s);*/
            
            //Вычислить факториал числа
            
            /*Console.Write("Факториал числа n = ");
            int n = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                fact *= numbers[j];
            }
            Console.WriteLine($"Факториал числа = {fact}");
            
            var max = numbers.Max();
            Console.WriteLine($"Наибольшое значение в массиве = {max}");*/
            
            //Найти сумму и произведение всех чисел массива (массив инициализировать случайными значениями)
            
            //Console.WriteLine($"Сумма всех чисел в массиве = {sum}");
            //Console.WriteLine($"Произведение всех чисел в массиве = {mult}");
            
            //Посчитать четные и нечетные числа массива (массив инициализировать случайными значениями)
            
            //Console.WriteLine($"Четных чисел в массиве = {even}");
            //Console.WriteLine($"Нечётных чисел в массиве = {odd}");
            
            /* Вывести на экран ряд натуральных чисел от минимума до максимума с шагом.
               Например, если минимум 10, максимум 35, шаг 5, то вывод должен быть таким: 10 15 20 25 30 35. 
               Минимум, максимум и шаг указываются пользователем (считываются из консоли).*/
            
            /*Console.Write("Минимум = ");
            int min = Int32.Parse(Console.ReadLine());
            Console.Write("Максимум = ");
            int max = Int32.Parse(Console.ReadLine());
            Console.Write("Шаг = ");
            int step = Int32.Parse(Console.ReadLine());
            for (int i = 0; min <= max; ++i)
            {
                Console.Write(min + " ");
                min += step;
            }*/
            
            //Ряд Фибоначчи (каждое следующее число = сумме двух предыдущих). Вывести на экран столько элементов ряда Фибоначчи, сколько указал пользователь (в консоли).
            
            /*Console.Write("Сколько элементов ряда Фибоначи вывести на экран = ");
            int num = Int32.Parse(Console.ReadLine());
            Fibbonachi(num);*/
            
            //Угадать случайное число.

            /* В программе генерируется случайное целое число от 0 до 100. 
            Пользователь должен его отгадать не более чем за 10 попыток. 
            После каждой неудачной попытки должно сообщаться больше или меньше введенное пользователем число, чем то, что загадано. 
            Если за 10 попыток число не отгадано, то вывести загаданное число.*/
            
            /*Random randInt = new Random();
            int intRand = randInt.Next(0, 100);
            int attempt = 0;
            Console.WriteLine(intRand);
            Console.WriteLine("Отгадайте загаданое число, у вас 10 попыток");
            for (int i = 0; attempt != 10; i++)
            {
                int input = Int32.Parse(Console.ReadLine());
                attempt++;
                if (input < intRand)
                {
                    Console.WriteLine($"Число {input} меньше");
                } else if (input > intRand)
                {
                    Console.WriteLine($"Число {input} больше");
                } else if (input == intRand)
                {
                    Console.WriteLine("Отлично, вы угадали число!");
                    break;
                }
            }
            if (attempt == 10)
            {
                Console.Write($"Увы, но вы не угадали - это число {intRand}");
            }*/
            
            /* Найти сумму n элементов (n ввести с консоли) следующего ряда чисел: 1 -0.5 0.25 -0.125 ...*/
            
            /* Console.Write("n элемент = ");
            int n = Int32.Parse(Console.ReadLine());
            double a = -0.5;
            double b = 1;
            double[] decim = new double[n];
            double sum = 0;
            for (int i = 0; i < decim.Length; i++)
            {
                decim[i] = b;
                sum += b;
                b = b * a;
                Console.Write($"{decim[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма n элементов = {sum}"); */
            
            /* На днях Иван у себя в прихожей выложил кафель, состоящий из квадратных черных и белых плиток. 
            Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток. Теперь Иван переживает, что узор из плиток, который у него получился, может быть не симпатичным. 
            С точки зрения дизайна симпатичным узором считается тот, который не содержит в себе квадрата 2х2, состоящего из плиток одного цвета.*/
            // 1 - это клетка закрашена (черный), 0 пусто (белый)
            
            /*int[,] oneZero = new int[4, 4];
            Random zeroAndOne = new Random();
            
            for (int i = 0; i < oneZero.GetLength(0);i++)
            {
                Console.WriteLine($"Строка {i+1}");
                for (int j = 0; j < oneZero.GetLength(1); j++)
                {
                    Console.WriteLine($"Индекс числа {j} ");
                    oneZero[i, j] = zeroAndOne.Next(2);
                }
            }
            
            for (int i = 0; i < oneZero.GetLength(0); i++)
            {
                for (int j = 0; j < oneZero.GetLength(1); j++)
                {
                    Console.Write($"{oneZero[i, j]}\t");
                }
                Console.WriteLine();
            }
            
            int count = 0;
            for (int i = 0; i < oneZero.GetLength(0); i++)
            {
                for (int j = 0; j < oneZero.GetLength(1); j++)
                {
                    if (oneZero[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            
            if (oneZero[0, 0] == 1 && oneZero[0,1] == 1 && oneZero[1, 0] == 1 && oneZero[1,1] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[0, 2] == 1 && oneZero[0, 3] == 1 && oneZero[1, 2] == 1 && oneZero[1, 3] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[2, 0] == 1 && oneZero[2, 1] == 1 && oneZero[3, 0] == 1 && oneZero[3, 1] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[2, 2] == 1 && oneZero[2, 3] == 1 && oneZero[3, 2] == 1 && oneZero[3, 3] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[1, 1] == 1 && oneZero[1, 2] == 1 && oneZero[2, 1] == 1 && oneZero[2, 2] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[1, 0] == 1 && oneZero[1, 1] == 1 && oneZero[2, 0] == 1 && oneZero[2, 1] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[1, 2] == 1 && oneZero[1, 3] == 1 && oneZero[2, 2] == 1 && oneZero[2, 3] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[0, 1] == 1 && oneZero[0, 2] == 1 && oneZero[1, 1] == 1 && oneZero[1, 2] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (oneZero[2, 1] == 1 && oneZero[2, 2] == 1 && oneZero[3, 1] == 1 && oneZero[3, 2] == 1)
            {
                Console.WriteLine("Узор несимпатичный");
            } else if (count == 16)
            {
                Console.WriteLine("Узор несимпатичный");
            }
            else
            {
                Console.WriteLine("Узор симпатичный!!");
            } */
        }
    }
}