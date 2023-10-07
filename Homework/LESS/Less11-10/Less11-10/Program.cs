/*Табло

На хоккейном стадионе в одном большом городе расположено большое прямоугольное табло. 
Оно имеет n строк и m столбцов (то есть состоит из n x m ячеек). Во время хоккейного матча это табло служит для отображения счета и времени, 
прошедшего с начала тайма, а в перерывах на нем показывают различную рекламу.
В связи с этим возникла задача проверки возможности показа на этом табло определенной рекламной заставки. 
Заставка также, как и табло, имеет размер n строк на m столбцов. 
Каждая из ячеек заставки окрашена в один из четырех цветов - трех основных: 
красный - R, 
зеленый - G, 
синий - B 
черный - .(точка).
Каждая из ячеек табло характеризуется своими цветопередаточными возможностями. 
Любая из ячеек табло может отображать черный цвет - это соответствует тому, что на нее вообще не подается напряжение. 
Также каждая из ячеек может отображать некоторое подмножество множества основных цветов. В этой задаче эти подмножества будут кодироваться следующим образом:
0 - ячейка может отображать только черный цвет; 
1 - ячейка может отображать только черный и синий цвета; 
2 - ячейка может отображать только черный и зеленый цвета; 
3 - ячейка может отображать только черный, зеленый и синий цвета; 
4 - ячейка может отображать только черный и красный цвета; 
5 - ячейка может отображать только черный, красный и синий цвета; 
6 - ячейка может отображать только черный, красный и зеленый цвета; 
7 - ячейка может отображать только черный, красный, зеленый и синий цвета.*/

using System;
namespace Less11_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] colors = {'R', 'G', 'B', '.'};
            string color;
            //bool answer = false;
            int count = 0;
            
            
            Console.Write("Введите колличество строк n = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Введите коллчество столбцов m = ");
            int m = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Заполните заставку цветами:");
            char[,] screen = new char[n, m];
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                Console.WriteLine($"Строка {i+1}");
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write($"Элемент {j+1} = ");
                    screen[i, j] = Char.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Заполните табло цифрами цветопередачи:");
            char[,] scoreboard = new Char[n, m];
            for (int i = 0; i < scoreboard.GetLength(0); i++)
            {
                Console.WriteLine($"Строка {i+1}");
                for (int j = 0; j < scoreboard.GetLength(1); j++)
                {
                    Console.Write($"Элемент {j+1} = ");
                    char number = Char.Parse(Console.ReadLine());
                    scoreboard[i, j] = number;
                    string ex = scoreboard[i, j].ToString();
                    if (ex == "0")
                    {
                        color = ".";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }

                    } else if (ex == "1")
                    {
                        color = ".B";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "2")
                    {
                        color = ".G";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "3")
                    {
                        color = ".GB";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "4")
                    {
                        color = ".R";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "5")
                    {
                        color = ".RB";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "6")
                    {
                        color = ".R";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    } else if (ex == "7")
                    {
                        color = ".RGB";
                        int result = color.IndexOf(screen[i, j].ToString());
                        if (result == -1)
                        {
                            count++;
                        }
                    }
                }
            }
            //Показать ЗАСТАВКУ
            Console.WriteLine("======ЗАСТАВКА====");
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write(screen[i,j] + "   "); 
                }
                Console.WriteLine();
            }
            //Показать ТАБЛО
            Console.WriteLine("======ТАБЛО=======");
            for (int i = 0; i < scoreboard.GetLength(0); i++)
            {
                for (int j = 0; j < scoreboard.GetLength(1); j++)
                {
                    Console.Write(scoreboard[i,j] + "   "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================");
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YES");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO");
                Console.WriteLine($"{count} элемента/элемент не проходят по цветопередаче");
            }
        }
    }
}