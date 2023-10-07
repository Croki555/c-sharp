using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Lesson10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задача 1. Создайте файл numbers.txt и запишите в него натуральные числа от 1 до 500 через запятую.
            
            FileStream file = new FileStream("C:\\TextC#\\numbers.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file); 
            for (int i = 1; i <= 500; i++)
            {
                if (i == 500)
                {
                    writer.Write($"{i} ");
                    break;
                }
                writer.Write($"{i}, ");
            }
            writer.Close();
            
            //Задача 2. Дан массив строк: "red", "green", "black", "white", "blue". Запишите в файл элементы массива построчно (каждый элемент в новой строке).
            string[] array = {"red", "green", "black", "white", "blue"};
            FileStream file1 = new FileStream("C:\\TextC#\\colors.txt", FileMode.Create);
            StreamWriter writer1 = new StreamWriter(file1);
            foreach (string text in array)
            {
                writer1.WriteLine(text);
            }
            writer1.Close();
            //Задача 3. Возьмите любой текстовый файл, и найдите в нем размер самой длинной строки.
            FileStream file2 = new FileStream("C:\\TextC#\\text.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file2);
            string line;
            string way = "C:\\TextC#\\text.txt";
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line + ". Длина строки равна = " + line.Length);
            }
            reader.Close();
        }
    }
}