using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp2
{
    internal class Human
    {
        public string Name;
        public int Age;
        public double Weight = 60.00;
        public int Mood = 10;
        public void Write(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }
        public int GetMood
        {
            get { return Mood; }
        }

        public string Print()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nВес: {Weight}\nНастроение: {Mood}";
        }

        public void Eat(double e)
        {
            if (e >= 5)
            {
                Age++;
                Weight += e / 2;
            }
            for (int i = 0; i < 4; i++) Walk();
            for (int i = 0; i < 2; i++) Dance();
        } 
        public void Walk()  => Mood++;
        public void Dance() => Mood+=2;
        public int Work
        {
            set
            {
                if( value +- 2 <= 0)
                {
                    Mood = 1;
                } else
                {
                    Mood = value;
                }
            }
            get { return Work; }
        }
        public void Work9()
        {
            for(int i = 0; i < 9; i++)
            {
                Mood -= 2;
                if(GetMood<= 0)
                {
                    Mood = 1;
                }
            }
        }
    }
}
