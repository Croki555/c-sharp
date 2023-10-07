/*Напишите программу "Колледж", в которой опишите классы "Ученик" и "Группа". Класс "Ученик" должен содержать информацию: 
ФИО, Возраст, Пол, Цвет кожи. Добавьте возможность добавления учеников в группу, просмотра информации о них и их отчисление.*/

using System;
using System.Collections.Generic;

namespace Less16
{
  class Student
  {
    public string FullName;
    public int Age;
    public string Gender;
    public string Nationality;

    public Student() : this("Неизвестно")
    {
    }

    public Student(string fullName) : this(fullName, 18, "Неизвестно", "Неизвестно")
    {
    }

    public Student(string fullName, int age) : this(fullName, age, "Неизвестно", "Неизвестно")
    {
    }

    public Student(string fullName, int age, string gender) : this(fullName, age, gender, "Неизвестно")
    {
    }
    public Student(string fullName, int age, string gender, string nationality)
    {
      this.FullName = fullName;
      this.Age = age;
      this.Gender = gender;
      this.Nationality = nationality;
    }

    public void GetInfo()
    {
      Console.WriteLine($"ФИО: {FullName}; Возраст: {Age} лет; Пол: {Gender}; Национальность: {Nationality}");
    }

    public string Get()
    {
      string text = $"ФИО: {FullName}; Возраст: {Age} лет; Пол: {Gender}; Национальность: {Nationality}";
      return text;
    }
    
    internal class College
    {
      public static void Main(string[] args)
      {
        var Group = new List<string>();
        Student one = new Student("fdfdf",19);
        Student two = new Student("Соколов Павел Андреевич", 19, "Мужской", "Русский");
        Student three = new Student();
        Group.Add(one.Get());
        Group.Add(two.Get());
        Group.Add(three.Get());
        foreach (var a in Group)
        {
          Console.WriteLine(a);
        }
      }
    }
  }
}