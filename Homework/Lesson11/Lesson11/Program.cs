using System;

namespace Lesson11
{
    // Создайте какой-нибудь класс (например класс Автомобиль), объявите в нем поля с различными режимами доступа (private, protected, internal, public). 
    // Создайте объект класса, и попытайтесь записать/получить данные с различных полей.
    public class Cars
    {
        public string name;
        private int id_car;
        protected int model;
        internal int sail;
    }
    class Car
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();
            car1.name = "Volvo";
            Cars car2 = new Cars();
            car2.name = "BMW";
            Console.WriteLine(car2.name);

            Cars id1 = new Cars();
            // id1.id_car = 1743745; //Нет доступа т.к private
            // id1.model = 82475728; // Аналогично с protected

            Cars sail1 = new Cars();
            sail1.sail = 100000;
            Console.WriteLine($"Название первой машины {car1.name} её цена {sail1.sail} рублей.");
        }
    }
}