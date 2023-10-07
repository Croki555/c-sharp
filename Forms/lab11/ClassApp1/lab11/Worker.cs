using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Worker
    {
        public string Name;
        public int Age;
        double Weight = 60.00;

        public Worker(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Print()
        {
            return $"Рабочий: {Name} \nВозраст: {Age} \nВес: {Weight}";
        }
        public double Ves
        {
            get { return Weight; }
            set
            {
                if(value > 10)
                {
                    Age++;
                    Weight += value / 2;
                } else
                {
                    Weight += value;
                }
            }

        }
        public void SetEat(double eda)
        {
            if (eda > 10)
            {
                Age++;
                Weight += eda / 2;
            } else
            {
                Weight += eda;
            }            
        }

        public double GetEat()
        {
            return Weight;
        }
    }
}
