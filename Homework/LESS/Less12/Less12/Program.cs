/*1.    Номера автобусов
Однажды Вася очень долго просидел на остановке, прежде чем дождался своего автобуса. Чтобы как-то занять время, 
он решил записывать на листочке государственные регистрационные номера проходящих мимо автобусов. 
При этом производилась запись лишь основного номера, без учета региональной принадлежности.
Основная часть государственного регистрационного номера состоит из 6 символов: трех букв и трех цифр. 
Сначала идет буква, затем 3 цифры и еще 2 буквы заканчивают запись. 
В качестве цифр могут использоваться любые цифры от 0 до 9, а в качестве букв только прописные буквы, 
обозначения которых присутствуют как в английском, так и в русском алфавите, т.е. только следующие символы: A, B, C, E, H, K, M, O, P, T, X, Y. 
Например, «P204BT» - правильный номер, а «X182YZ» и «ABC216» - нет.
Ваша задача заключается в проверке правильности проделанной Васей работы. А именно, нужно определить, какие из номеров соответствуют принятому стандарту, а какие нет.
Номера читаем в цикле из консоли. Если номер пустой (нажали ENTER), то выходим из программы
*/
/*2.    Сжатие бинарных последовательностей
  Последовательность из символов «0» и «1» называется бинарной. Они широко применяются в информатике и других науках. 
  Одно из неудобств бинарных последовательностей – их трудно запоминать. Для решения этой проблемы были предложены разные способы их сжатия. 
  Программист Слава использует следующий способ: просматривая последовательность слева направо, он заменяет «1» на «a», «01» на «b», «001» на «c», …, 
  «00000000000000000000000001» на «z». Напишите программу, которая поможет Славе автоматизировать этот способ сжатия.
*/
/* 3.   Стрелки
   Задана последовательность, состоящая только из символов ‘>’, ‘<’ и ‘-‘. 
   Требуется найти количество стрел, которые спрятаны в этой последовательности. 
   Стрелы – это подстроки вида ‘>>-->’ и ‘<--<<’ (наконечник стрелы, древко и оперение).
*/
/* 4.	Нумеролог
Чтобы предсказать судьбу человека, нумеролог берет время жизни человека в секундах, затем складывает все цифры этого числа. 
Если полученное число состоит более чем из одной цифры, операция повторяется, пока в числе не останется одна цифра. 
Затем по полученной цифре и числу операций, необходимых для преобразования числа в цифру нумеролог предсказывает судьбу человека. 
Нумеролог плохо умеет считать, а числа, с которыми он работает, могут быть очень большими. Напишите программу, которая бы делала все расчеты за него.
*/
/* 5.   Перестановка
Если Вы читали Гарри Поттера, то знаете, что повелитель зла, Лорд Волдеморт создал свое имя путем перестановки букв в своем настоящем имени. Так из имени «Tom Marvolo Riddle» он получил «I am Lord Voldemort».
Напишите программу, которая проверяет, можно ли получить из одного имени другое путем перестановки его букв. При этом регистром букв нужно пренебречь.
На входе два слова (можно в разных строках, а можно вспомнить про метод Split)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Less12
{
    internal class Program
    {
        public static void BusRegNum(string ex1)
        {
            string symbols = "ABCEHKMOPTXY";
            string numbers = "0123456789";
            Console.WriteLine($"Регистрационный номер автобуса = {ex1}");
            var StringList = ex1.ToCharArray();
            bool error = true;

            try
            {
                for (int i = 0; i < ex1.Length; i++)
                {
                    if (ex1.Length == 0)
                    {
                        Console.WriteLine("Номер пустой!! Для выхода из программы нажмите ENTER");
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            error = false;
                            break;
                        }
                    }
                    if(char.IsNumber(StringList[0]) || char.IsNumber(StringList[ex1.Length-1]) || char.IsNumber(StringList[ex1.Length-2]))
                    {
                        error = false;
                    }

                    if (symbols.IndexOf(StringList[0].ToString()) == -1)
                    {
                        error = false;
                    }

                    if (numbers.IndexOf(StringList[1].ToString()) == -1 || numbers.IndexOf(StringList[2].ToString()) == -1 || numbers.IndexOf(StringList[1].ToString()) == -1)
                    {
                        error = false;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("Номер пустой!! Для выхода из программы нажмите ENTER");
                }
            }

            if (error == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Номер {ex1} правильный");
                Console.ResetColor();
            } else if (error == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Номер {ex1} неправильный");
                Console.ResetColor();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Упражнение №1");
            /*string ex1 = "X182YZ";
            string ex2 = "Х182YZ";//Х - русская
            string ex3 = "ABC216";
            BusRegNum(ex1);
            BusRegNum(ex2);
            BusRegNum(ex3);*/
            
            Console.WriteLine("Упражнение №2");
            /*string enAlp = ("abcdefghijklmnopqrstuvwxyz");
            string example = "110000011101";//dcca
            int count = 0;
            string result = "";
            for (int i = 0; i < example.Length; i++) 
            { 
                if (example[i] == '1') 
                {
                    result += enAlp[count];
                    count = 0; 
                } 
                else 
                    count++; 
            } 
            Console.WriteLine(result);*/
            
            Console.WriteLine("Упраженение №3");
            /*string arrows = "<--<<<--<<<--<<>>--><--<<--<>><--<<";
            string arrow1 = ">>-->";
            string arrow2 = "<--<<";
            var arr = "";
            int count = 0;
            for (int i = 0; i < arrows.Length; i++)
            {
                arr += arrows[i];
                if (arr.Length == 5)
                {
                    if (arr == arrow1 || arr == arrow2)
                    {
                        count++;
                        arr = null;
                    } else if (arr != arrow1 || arr != arrow2)
                    {
                        arr = null;
                    }
                }
            }
            Console.WriteLine($"Всего {count} стрел");*/
            
            Console.WriteLine("Упраженение №5");
            /*string word1 = "house";
            string word2 = "sueoh";
            bool result = false;
            for (int i = 0; i < word2.Length; i++)
            {
                if (word1.Length == word2.Length)
                {
                    if (word1.IndexOf(word2[i]) != -1)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            if (result == true)
            {
                Console.WriteLine($"Моможно составить из слова [{word2}] слово [{word1}]");
            } else
            {
                Console.WriteLine($"Невозможно составить из слова [{word2}] слово [{word1}]");
            }*/
        }
    }
}