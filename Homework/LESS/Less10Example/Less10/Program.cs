using System;

namespace Example
{
        public class Person
        {
                //Все поля закрыты
                string fam = "", status = "", health = "";

                int age = 0, salary = 0;

                //Методы-свойства
                //Чтение, запись при первом обращении (Read, Write-once)
                public string Fam
                {
                        set
                        {
                                if (fam == "") fam = value;
                        }
                        get { return (fam); }
                }

                //стратегия - только чтение (Read-only)
                public string Status
                {
                        get { return (status); }
                }

                //Стратегия - чтение и запись (Read, Write)
                public int Age
                {
                        set
                        {
                                age = value;
                                if (age < 7) status = "ребенок";
                                else if (age < 17) status = "школьник";
                                else if (age < 22) status = "студент";
                                else status = "служащий";
                        }
                        get { return (age); }
                }

                //Стратегия - только запись (Write-only)
                public int Salary
                {
                        set { salary = value; }
                }

                static void Main(string[] args)
                {
                        Person person_1 = new Person();
                        person_1.Fam = "Петров";
                        person_1.Age = 21;
                        person_1.Salary = 1000;
                        Console.WriteLine("Фамилия = {0}, возраст = {1} лет, статус = {2}", person_1.Fam, person_1.Age, person_1.Status);
                        person_1.Fam = "Иванов"; // не установит новую фамилию тк она уже установлена
                        person_1.Age += 1;
                        Console.WriteLine("Фамилия = {0}, возраст = {1} лет, статус = {2}", person_1.Fam, person_1.Age, person_1.Status);
                        Console.ReadKey();

                }
        }
}