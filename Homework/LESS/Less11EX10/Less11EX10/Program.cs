
using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] code = { "P", "PB", "PG", "PR", "PGB", "PRB", "PRG", "PRGB" };

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--- РАЗМЕР ТАБЛО ---");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Кол-во строк (высота): ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Кол-во столбцов (ширина): ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("::Кодировка элементов::");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < code.Length; i++)
                {
                    Console.WriteLine($"Код {i} - элемент {code[i]}");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" +
                    "! ВСЕ ДАННЫЕ вводить через ПРОБЕЛ !");
                Console.ForegroundColor = ConsoleColor.White;

                string[,] zastavka = new string[n, m];
                string zastavka_line;
                string[] z_line = new string[m];

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n" +
                    $"--- ЭЛЕМЕНТЫ ЗАСТАВКИ --- Столбцов {m} - ВВОДИТЬ: имя элемента");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Строка {i + 1} | ");
                    zastavka_line = Console.ReadLine();
                    z_line = zastavka_line.Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        zastavka[i, j] = z_line[j];
                    }
                }

                int[,] tablo = new int[n, m];
                string tablo_line;
                string[] t_line = new string[m];

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" +
                    $"--- ЭЛЕМЕНТЫ ТАБЛО --- Столбцов {m} - ВВОДИТЬ: код элемента");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Строка {i + 1} | ");
                    tablo_line = Console.ReadLine();
                    t_line = tablo_line.Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        tablo[i, j] = Convert.ToInt32(t_line[j]);
                    }
                }

                bool show = true;
                int item_tablo = 0;
                int k = 0;
                
while (show && k < n)
                {
                    int j = 0;
                    while (show && j < m)
                    {
                        item_tablo = tablo[k, j];
                        char[] char_zastavka = zastavka[k, j].ToCharArray();
                        char[] char_tablo = code[item_tablo].ToCharArray();
                        for (int i = 0; i < char_zastavka.Length; i++)
                        {
                            int count = 0;
                            foreach (char c in char_tablo)
                            {
                                if (char_zastavka[i] == c)
                                {
                                    count += 1;
                                }
                            }
                            if (count == 1)
                            {
                                show = true;
                                j++;
                            }
                            else
                            {
                                show = false;
                                j++;
                            }
                        }
                    }
                    k++;
                }

                Console.ForegroundColor = ConsoleColor.Red;

                if (show)
                {
                    Console.WriteLine("\n" +
                        "YES");
                }
                else
                {
                    Console.WriteLine("\n" +
                        "NO");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Продолжить тестирование? Yes/No\n" +
                    "Ответ: ");
                var answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--- ТЕСТИРОВАНИЕ ПРОДОЛЖАЕТСЯ ---\n" +
                        "");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--- ВЫ ЗАВЕРШИЛИ ПРОГРАММУ ---");
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}