using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp3
{
    internal class Shopper
    {
        public string ProductName = "Неизвестно";
        public double Price; //цена
        public int Quantity; //количествло
        public double Wallet = 5000.00; //рубли
        public double Mood = 10.00;

        public double GetMood() { return Mood; }
        public string InfoMood()
        {
            var str = "";
            if (GetMood() > 15) { str = "Бодрое";}
            if (GetMood() >= 5 && GetMood() <= 15) { str = "Нормальное"; }
            if (GetMood() >= -10 && GetMood() <= 5) { str = "Плохое"; }
            if (GetMood() < -10) { str = "Депрессивное"; }
            return str;
        }
        public string InfoProduct()
        {
            return $"Товар: {ProductName};\nКоличество: {Quantity};\nСтоимость: {Price} рублей;\nБаланс кошелька: {Wallet}\nНастроение: {InfoMood()}";
        }
        public void Buy(string name, double p, int c)
        {

            this.ProductName = name;
            this.Price = p;
            this.Quantity = c;
            if (Wallet > (Price * c))
            {
                Wallet -= (Price * c);
                this.Mood = GetMood() + ((Price * c) / 2);
            }
            else if (Wallet < (Price * c))
            {
                this.ProductName = $"{name} (НЕ ХВАТАЕТ {Math.Abs(Wallet - (Price * c))} РУБЛЕЙ!!)";
                this.Mood = GetMood() - (Math.Abs(Wallet - (Price * c)));
            }
        }
    }
}
