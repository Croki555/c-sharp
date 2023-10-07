using System;

namespace Less1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Вычислить оптимальную для пользователя массу. Сравнить ее
            //с реальной массой и вывести в консоль рекомендацию поправиться
            //или похудеть на определенное количество килограммов. Расчет опти-
            //мальной массы производится по формуле: рост (см)–100. Например:
            // Ваш рост (см) 175
            // Ваш вес (кг): 95
            // Вам необходимо похудеть на 15 кг;
            //////////////////////////////////////////////////////////////////////////////////
             Console.Write("Ваш рост (см): "); 
             int rise = Convert.ToInt32(Console.ReadLine());
             Console.Write("Ваш вес (кг): ");
             int weight = Convert.ToInt32(Console.ReadLine());
             var optWeight = rise - 100;
             var add = optWeight - weight;
             var del = weight - optWeight;
             if (optWeight > weight)
             {
                 Console.WriteLine($"Вам необходимо поправиться на {add} кг");
             } else if (optWeight < weight)
             {
                 Console.WriteLine($"Вам необходимо похудеть на {del} кг");
             }
             else
             {
                 Console.WriteLine("У вас всё хорошо с весом");
            }

             Console.ReadKey();
             ////////////////////////////////////////////////////////////////////////
             /* Написать программу, которая запрашивает у пользователя число 
             из диапазона [1..10], а затем выводит на экран все его делители */
             ////////////////////////////////////////////////////////////////////////
             /* Console.Write("Введите число от 1 до 10 = ");
             int number = Convert.ToInt32(Console.ReadLine());
             switch (number)
             {
                 case 1:
                     Console.WriteLine($"Делители числа {number} = 1");
                     break;
                 case 2:
                     Console.WriteLine($"Делители числа {number} = 1 и 2");
                     break;
                 case 3:
                     Console.WriteLine($"Делители числа {number} = 1 и 3");
                     break;
                 case 4:
                     Console.WriteLine($"Делители числа {number} = 1, 2 и 4");
                     break;
                 case 5:
                     Console.WriteLine($"Делители числа {number} = 1 и 5");
                     break;
                 case 6:
                     Console.WriteLine($"Делители числа {number} = 1, 2, 3 и 6");
                     break;
                 case 7:
                     Console.WriteLine($"Делители числа {number} = 1 и 7");
                     break;
                 case 8:
                     Console.WriteLine($"Делители числа {number} = 1, 2, 4 и 8");
                     break;
                 case 9:
                     Console.WriteLine($"Делители числа {number} = 1, 3 и 9");
                     break;
                 case 10:
                     Console.WriteLine($"Делители числа {number} = 1, 2, 5 и 10");
                     break;
                 default:
                     Console.WriteLine("Число должно быть целым и в пределах от 1 до 10");
                     break;
             }
             Console.ReadKey(); */
             ///////////////////////////////////////////////////////////////////////////////////
             /* Написать программу, которая определяет, сколько элементов
             с равными значениями содержится в массиве. Например:
             Задайте количество элементов массива: 7
             Введите элементы массива: 3 6 1 3 7 3 7
             В данном массиве два элемента равны 7, три элемента равны 3 */

             /* Console.Write("Задайте количество элементов массива: ");
             int num = Convert.ToInt32(Console.ReadLine());
             int[] numbers = new int [num];
             Console.WriteLine("Введите элементы массива: ");
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.Write($"Введите элемент массива = ");
                 int number = Convert.ToInt32(Console.ReadLine());
                 numbers[i] = number;
             }
             Array.Sort(numbers);
             for (int el = 0; el < numbers.Length-1; el++)
             {
                 if (numbers[el] != int.MaxValue)
                 {
                     int count = 1;
                     for (int j = el + 1; j < numbers.Length; j++)
                     {
                         if (numbers[el] == numbers[j]) { count++; numbers[j] = int.MaxValue; }
                     }
                     if (count >= 2)Console.WriteLine($"В данном массиве {count} элемента = {numbers[el]}");
                 }
             }
             Console.ReadKey(); */
        }
    }
}