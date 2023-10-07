using System;

namespace Lesoon12
{
    // Создайте класс Телевизор. В нем есть поле текущий канал. 
    //Предусмотрите в нем возможность переключения каналов: следующий канал, предыдущий канал, переход к каналу по номеру. 
    //Учтите, что канал не может иметь отрицательный номер.
    class TVSet
    {
        public void SwitchOn()
        {
            Console.WriteLine("Телевизор включён");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Телевизор выключен");
        }

        public void SelectChannel()
        {
            Console.Write("Выберите канал = ");
            int channel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы на {channel} канале");
        }
    }
    class Program
    {
        static void Main()
        {
            TVSet myTV = new TVSet();
            myTV.SwitchOn();// включаем телевизор, switchedOn = true;
            // myTV.SwitchOff(); // выключаем телевизор, switchedOn = false;
            myTV.SelectChannel();
        }
    }
}