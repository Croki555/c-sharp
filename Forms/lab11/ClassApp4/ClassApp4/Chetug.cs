using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp4
{
    class Chetug : Figura
    {
        public string tip;
        public Chetug(string t, double v, double d) : base(v, d)
        {
            tip = t;
        }
        public string inf()
        {
            return $"Тип четырехугольника: {tip}";
        }
    }
}
