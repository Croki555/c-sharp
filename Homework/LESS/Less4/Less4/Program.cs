using System;
using System.Diagnostics;

namespace Less4
{
    class Addres
    {
        public string city;
        public string street;
        public int house;
        public void Print()
        {
            Console.WriteLine($"Адрес [ {city}, {street}, {house} ]");
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Создаём объект почтовой организации");
            Addres first = new Addres();
            Console.Write("Город: ");
            string a = Console.ReadLine();
            first.city = a;
            Console.Write("Улица: ");
            string b = Console.ReadLine();
            first.street = b;
            Console.Write("Дом: ");
            int c = Convert.ToInt32(Console.ReadLine());
            first.house = c;
            Console.WriteLine("Объект создан");
            Console.WriteLine("Нажмите на цифру соответсвующую вашему предпочтению");
            Console.WriteLine("Полный адрес = 1");
            Console.WriteLine("Изменить город = 2");
            Console.WriteLine("Изменить улицу = 3");
            Console.WriteLine("Изменить номер дома = 4");
            Console.WriteLine("Удалить объект = 5");
            int number = 1;
            while (number != 0)
            {
                Console.Write("Ваш номер = ");
                int numbers = Convert.ToInt32(Console.ReadLine());
                number = numbers;
                switch (numbers)
                {
                    case 1:
                        first.Print();
                        break;
                    case 2:
                        Console.Write("Новый город: ");
                        first.city = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Новая улица: ");
                        first.street = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Новый номер: ");
                        first.house = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        Console.WriteLine("Объект удалён");
                        first = null;
                        break;
                }
            }
        }
    }
}