/*Для тех кто выполнил предыдущее задание 
Задача 1. Класс Phone.
Создайте класс Phone, который содержит переменные number, model и weight.
Создайте три экземпляра этого класса. 
Выведите на консоль значения их переменных. 
Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. 
Выводит на консоль сообщение “Звонит {name}”.
Метод getNumber – возвращает номер телефона. Вызвать эти методы для каждого из объектов.
Добавить конструктор в класс Phone, который принимает на вход три параметра для инициализации переменных класса - number, model и weight. 
Добавить конструктор, который принимает на вход два параметра для инициализации переменных класса - number, model. 
Добавить конструктор без параметров.
Вызвать из конструктора с тремя параметрами конструктор с двумя. 
Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего. Вызвать этот метод.
Создать метод sendMessage с аргументами переменной длины. 
Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов.*/

using System;

namespace Less17
{
    class Phone
    {
        public long Number;
        public string Model;
        public int Weight;
        
        public Phone() : this(0){}
        public Phone(long number) : this(number,"Неизвестно",0){}
        public Phone(int number, string model) : this(number, model,0){}
        public Phone(long number, string model, int weight)
        {
            this.Number = number;
            this.Model = model;
            this.Weight = weight;
        }
        public void Print()
        {
            Console.WriteLine($"№ телефона: {Number}; Модель: {Model}; Вес: {Weight}");
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        
        public void ReceiveCall(string name, long number)
        {
            Console.WriteLine($"Звонит {name} с номера {number}");
        }
        public long GetNumber()
        {
            return Number;
        }

        public void SendMessage(long[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"Номер: {number}");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Создание 3-х экземпляров этого класса
            Phone one = new Phone(89216758593, "Mi Note Pro", 3);
            Phone two = new Phone(89214034901, "Mi Note 2", 2);
            Phone three = new Phone(89215903123, "Mi Note 5", 3);
            one.Print();
            two.Print();
            three.Print();
            //Вызов метода ReceiveCall
            one.ReceiveCall("Петя");
            two.ReceiveCall("Ваня");
            three.ReceiveCall("Даня");
            //Вызов метода GetNumber
            Console.WriteLine(one.GetNumber());
            Console.WriteLine(two.GetNumber());
            Console.WriteLine(three.GetNumber());
            //Вызов перегруженного метода ReceiveCall
            one.ReceiveCall("Павел", one.GetNumber());
            //Вызов метода sendMessage
            long[]numbers = {one.GetNumber(),two.GetNumber(),three.GetNumber()};
            one.SendMessage(numbers);

    }
    }
}