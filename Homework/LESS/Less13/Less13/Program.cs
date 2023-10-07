using System;
using System.Linq;

namespace Less13
{
    internal class Program
    {
        /*  1.	Проверка даты
            Ввести с консоли строку в формате ДД.ММ.ГГГГ. Проверьте является ли введенная строка валидной датой.
            2.	Поиск наиболее популярного месяца
            Объявите массив произвольных дат (в оригинале это даты продаж). Найдите самый популярный месяц.
            Подсказка: реализовать через временный массив кортежей (DateTime, int)
            3.	Найти количество дней между двумя датами.
            4.	Найти "день программиста" для указанного года (ввести с консоли).
            5.	Известен номер n некоторого дня года (1 ≤ n ≤ 365). Определить номер и название дня недели, на который выпадает данный день года.
            6.	Задана дата экзамена. С клавиатуры надо вводить другую дату, в случае, если дата раньше даты экзамена, вывести "осталось n дней",
             если уже прошел экзамен "прошло n дней", и если экзамен сегодня "сегодня экзамен!"
        */
        public static void Number1()
        {
            
                bool result = false;
                while (result == false)
                {
                    try
                    {
                        Console.WriteLine("Введите дату в формате DD.MM.YYYY");
                        string[] date = Console.ReadLine().Split('.');
                        int day = Int32.Parse(date[0]);
                        int month = Int32.Parse(date[1]);
                        int year = Int32.Parse(date[2]);
                        DateTime date1 = new DateTime(year, month, day);
                        result = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Дата валидна!!");
                        Console.WriteLine(date1.ToString("d"));
                        Console.ResetColor();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Дата не валидна");
                        Console.ResetColor();
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Дата не валидна");
                        Console.ResetColor();
                    }
                }
        }
        public static void Number2()
        {
            DateTime[] dates = new DateTime[10];
            dates[0] = new DateTime(2000,12,29);
            dates[1] = new DateTime(2001,10,11);
            dates[2] = new DateTime(2003,12,22);
            dates[3] = new DateTime(2002,05,17);
            dates[4] = new DateTime(2005,05,15);
            dates[5] = new DateTime(2009,12,22);
            dates[6] = new DateTime(2010,01,12);
            dates[7] = new DateTime(2022,11,30);
            dates[8] = new DateTime(2003,01,21);
            dates[9] = new DateTime(2012,12,20);
            /*foreach (var data in dates)
            {
                Console.WriteLine(data.ToString("d"));
            }*/
            int[] month = new int[dates.Length];
            for (int i = 0; i < dates.Length; i++)
            {
                month[i] = dates[i].Month;
            }
            int max = 0;
            int countMax = 0;
            for (int i = 0; i < month.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < month.Length; j++)
                {
                    if (month[i] == month[j])
                    {
                        count++;
                    };
                    if (count > countMax)
                    {
                        countMax = count;
                        max = month[i];
                    }
                }
            }
            Console.WriteLine($"Чаще всего встречается месяц {max}");
        }
        public static void Number3()
        {
            Console.WriteLine("Введите вашу дату Рождения в формате dd.mm.yyyy");
            string[] dateYear = Console.ReadLine().Split('.');
            int year = Convert.ToInt32(dateYear[2]);
            int month = Convert.ToInt32(dateYear[1]);
            int day = Convert.ToInt32(dateYear[0]);
            DateTime dt1 = new DateTime(year, month, day);
            DateTime dt2 = DateTime.Now;
            TimeSpan result = dt2.Subtract(dt1);
            Console.WriteLine($"Разница в днях между вашим днём Рождением и датой сегодняшнего дня = {result.Days} дней");
        }
        public static void Number4()
        {
            Console.Write("Введите год (начиная с 2009) = ");
            int year = Int32.Parse(Console.ReadLine());
            DateTime date;
            if (DateTime.IsLeapYear(year))
            {
                date = new DateTime(year, 09, 12);
            }
            else
            {
                date = new DateTime(year, 09, 13);
            }
            Console.WriteLine($"День программиста {year} года : {date.ToString("dddd")}, {date.Day} сентября");
        }
        public static void Number5()
        {
            Console.Write("Год = ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("День = ");
            int day = Int32.Parse(Console.ReadLine()) - 1;
            DateTime dayWeek = new DateTime(year, 01, 01).AddDays(day);
            Console.WriteLine($"Число {dayWeek.Day}, день недели {dayWeek.ToString("dddd")}");
        }
        public static void Number6()
        {
            DateTime exam = new DateTime(2022, 3, 14);
            Console.WriteLine($"Дата экзамена {exam.ToString("d")}");
            try
            {
                Console.WriteLine("Введите дату в формате dd.mm.yyyy");
                string[] date = Console.ReadLine().Split('.');
                int day = Int32.Parse(date[0]);
                int month = Int32.Parse(date[1]);
                int year = Int32.Parse(date[2]);
                DateTime dt = new DateTime(year, month, day);
                if (dt < exam)
                {
                    TimeSpan result = exam.Subtract(dt);
                    Console.WriteLine($"Осталось {result.Days} день/дня/дней");
                }
                if (dt > exam)
                {
                    TimeSpan result = dt.Subtract(exam);
                    Console.WriteLine($"Прошло {result.Days} день/дня/дней");
                }
                if (dt == exam)
                {
                    Console.WriteLine("Сегодня экзамен!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дата не валидна");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дата не валидна");
                Console.ResetColor();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("№1");
            //Number1();
            Console.WriteLine("№2");
            //Number2();
            Console.WriteLine("№3"); 
            //Number3();
            Console.WriteLine("№4");
            //Number4();
            Console.WriteLine("№5");
            //Number5();
            Console.WriteLine("№6");
            //Number6();
        }
    }
}