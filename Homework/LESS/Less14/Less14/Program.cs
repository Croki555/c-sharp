using System;
using System.Collections.Generic;

namespace Less14
{
    /*Student: Фамилия, Имя, Отчество, Дата рождения, Адрес, Телефон, Факультет, Курс. Вывести:
    список студентов заданного факультета;
    списки студентов для каждого факультета и курса;
    список студентов, родившихся после заданного года.*/
    class Student
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime BirthDay;
        public string Addres;
        public string Phone;
        public string Faculty;
        public int Path;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Students = new List<Student>
            {
                new Student {Surname = "Арбузов", Name = "Николай", Patronymic = "Николаевич", BirthDay = new DateTime(2000,5,24), Addres = "г.Спб", Phone = "260-15-63", Faculty = "Экономический", Path = 3},
                new Student {Surname = "Соколов", Name = "Павел", Patronymic = "Андреевич", BirthDay = new DateTime(2002,12,26), Addres = "г.Спб", Phone = "110-67-82", Faculty = "Экономический", Path = 3},
                new Student {Surname = "Тимофеев", Name = "Сергей", Patronymic = "Викторович", BirthDay = new DateTime(2001,1,21), Addres = "г.Спб", Phone = "343-34-55", Faculty = "Экономический", Path = 4},
                new Student {Surname = "Перлов", Name = "Кирилл", Patronymic = "Николаевич", BirthDay = new DateTime(2003,4,7), Addres = "г.Спб", Phone = "773-09-87", Faculty = "Экономический", Path = 1},
                new Student {Surname = "Крылова", Name = "Елена", Patronymic = "Петровна", BirthDay = new DateTime(2002,12,18), Addres = "г.Спб", Phone = "769-56-98", Faculty = "Экономический", Path = 2},
                new Student {Surname = "Кульчий", Name = "Даня", Patronymic = "Николаевич", BirthDay = new DateTime(2002,10,11), Addres = "г.Спб", Phone = "112-33-43", Faculty = "Юридический", Path = 4},
                new Student {Surname = "Иванов", Name = "Даня", Patronymic = "Борисович", BirthDay = new DateTime(2000,9,2), Addres = "г.Спб", Phone = "346-01-78", Faculty = "Юридический", Path = 3},
                new Student {Surname = "Петухов", Name = "Петя", Patronymic = "Борисович", BirthDay = new DateTime(2001,7,28), Addres = "г.Спб", Phone = "846-67-91", Faculty = "Юридический", Path = 2},
                new Student {Surname = "Крысюков", Name = "Сергей", Patronymic = "Николаевич", BirthDay = new DateTime(2001,8,30), Addres = "г.Спб", Phone = "471-554-00", Faculty = "Юридический", Path = 2},
                new Student {Surname = "Шишикова", Name = "Настя", Patronymic = "Борисовна", BirthDay = new DateTime(2003,7,22), Addres = "г.Спб", Phone = "163-33-23", Faculty = "Юридический", Path = 1},
            };
            //список студентов заданного факультета;
            var StudentsFaculty = new List<string>();
            Console.Write("Введите факультет (Юридический, Экономический: ");
            string F = Console.ReadLine();
            foreach (var Person in Students)
            {
                var student = $"ФИО: {Person.Surname} {Person.Name} {Person.Patronymic}; Факультет: {Person.Faculty}; Курс: {Person.Path}; Дата рождения: {Person.BirthDay.ToString("d")}";
                if (Person.Faculty == F)
                {
                    StudentsFaculty.Add(student);
                }
            }
            StudentsFaculty.Sort();
            foreach (string person in StudentsFaculty)
            {
                Console.WriteLine(person);
            }
            //списки студентов для каждого факультета и курса;
            var StudentsFacultyPath = new List<string>();
            Console.Write("Введите факультет ( Юридический, Экономический): ");
            string F2 = Console.ReadLine();
            Console.Write("Введите номер курса: ");
            int P = Int32.Parse(Console.ReadLine());
            foreach (var Person in Students)
            {
                var student = $"ФИО: {Person.Surname} {Person.Name} {Person.Patronymic}; Факультет: {Person.Faculty}; Курс: {Person.Path}; Дата рождения: {Person.BirthDay.ToString("d")}";
                if (Person.Faculty == F2 && Person.Path == P)
                {
                    StudentsFacultyPath.Add(student);
                }
            }
            StudentsFaculty.Sort();
            foreach (string person in StudentsFacultyPath)
            {
                Console.WriteLine(person);
            }
            //список студентов, родившихся после заданного года
            var StudentsYear = new List<string>();
            Console.Write("Введите год (от 2000 до 2003) : ");
            int Year = Int32.Parse(Console.ReadLine());
            foreach (var Person in Students)
            {
                var student = $"ФИО: {Person.Surname} {Person.Name} {Person.Patronymic}; Факультет: {Person.Faculty}; Курс: {Person.Path}; Дата рождения: {Person.BirthDay.ToString("d")}";
                if (Person.BirthDay.Year > Year)
                {
                    StudentsYear.Add(student);
                }
            }
            foreach (string person in StudentsYear)
            {
                Console.WriteLine(person);
            }
        }
    }
}