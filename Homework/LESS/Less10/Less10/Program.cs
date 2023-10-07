/*Создать класс Triangle, разработав следующие элементы класса:
2.	 Поля:
•	 int a, b, c;
1.	 Конструктор, позволяющий создать экземпляр класса  с заданными длинами сторон.
2.	 Методы, позволяющие:
o	 вывести длины сторон треугольника на экран; +
o	 расчитать периметр треугольника; +
o	 расчитать площадь треугольника. +
3.	 Свойства:
o	 позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи); +
o	 позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения). +
4.	 Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, по индексу 2 – к полю c, при других значениях индекса выдается сообщение об ошибке.
5.	 Перегрузка:
o	 операции ++ (--): одновременно увеличивает (уменьшает) значение полей a, b и c на 1;
o	 констант true и false: обращение к экземпляру класса дает значение true, если треугольник с заданными длинами сторон существует, иначе false;
o	 операции *:  одновременно домножает поля a, b и c на скаляр;
o	 преобразования типа Triangle в string (и наоборот).
*/

using System;

namespace Less10
{
    public class Triangle
    {
        private int a, b, c;

        public Triangle(int a, int b, int c) //Конструктор класса
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Print() //Метод вывда длин сторон треугольника
        {
            Console.WriteLine("Сторона a = {0}, b = {1} и c = {2}");
        }

        public int Perimeter() //Метод рассчитывания периметра треугольника
        {
            return a + b + c;
        }
        
        public int A //Свойство: чтения и записи стороны A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B //Свойство: чтения и записи стороны B 
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int C //Свойство: чтения и записи стороны C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        
        public bool ThisTriangle //Свойство получения информации, существует ли треугольник с данными сторонами
        {
            get
            {
                if (a < b + c & b < a + c & c < a + b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 

        public double Square() //Метод рассчитывания площади треугольника
        {
            int semiPerimeter = Perimeter() / 2; //Полупериметр
            double p = Double.Parse(semiPerimeter.ToString());
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        public int this[int index]
        {
            get
            {
                if (index == 1)
                {
                    return a;
                }
                else if (index == 2)
                {
                    return b;
                }
                else if (index == 3)
                {
                    return c;
                }
                else
                {   
                    throw new Exception("Индекс должен быть от 0 до 3");
                }
            }
            set
            {
                if( index == 0)
                {
                    a = value;
                } else if (index == 1)
                { 
                    b = value;
                } else if (index == 2)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Индекс вышел за границы");
                }
            }
        } //Индексатор
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(20,30,60);
            tr.Perimeter();
        }
    }
}