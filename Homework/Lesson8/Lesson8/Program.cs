using System;

namespace Lesson8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задача 1. Есть некий текст. Необходимо заменить в этом тексте все слова "Nikolay" на "Oleg".
            string text = "Сегодня Nikolay отправился на работу,но Nikolay не знал,что сегодня не его смена!";
            string name = "Oleg";
            if (text.Contains("Nikolay"))
            {
                Console.WriteLine(text.Replace("Nikolay", "Oleg"));
            }
            // Задача 2. Дан текст – «Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп.
            // Были описаны основные операторы и методы, которые используются для работы со строками». 
            // Обрежьте этот текст так, чтобы осталась только часть «Были описаны основные операторы и методы».
            string text2 = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шар. Были описаны основные операторы и методы, которые используются для работы со строками";
            text2 = text2.Remove(0, text2.IndexOf("Были"));
            text2 = text2.Remove(text2.IndexOf(", которые"));
            Console.WriteLine(text2);
            // Задача 3. Дана строка, которая содержит имена пользователей, разделенные запятой – "Login1,LOgin2,login3,loGin4". 
            // Необходимо разбить эту строку на массив строк (чтобы отдельно были логины), и перевести их все в нижний регистр.
            string text3 = "Login1,LOgin2,login3,loGin4";
            text3 = text3.ToLower();
            string[] myarray = text3.Split(',');
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
        }
    }
}