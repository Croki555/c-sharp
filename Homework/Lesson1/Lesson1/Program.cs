using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Есть прямоугольный треугольник с катетами а=5, b=7. Найдите площадь треугольника, s=?. Используя теорему Пифагора, найдите длину гипотенузы, с=?.
            //Кроме этого, найдите длину гипотенузы еще и с помощью теоремы косинусов. 
            double a = 5;
            double b = 7;
            double s = 0.5 * a * b;
            double c = Math.Floor(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)));
            double cos = Math.Floor(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2) - 2 * a * b * Math.Cos(90))); // ведь косинус угла с = 90 градусов, а это равно 0
            Console.WriteLine("Сторона с = " + c);
            Console.WriteLine("Cторона с по теореме косинусов = " + c);
            Console.WriteLine("Площадь равна = " + s);
        }
    }
}

  