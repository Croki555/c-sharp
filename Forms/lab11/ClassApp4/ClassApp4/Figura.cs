using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp4
{
    class Figura
    {
        protected double visota;
        protected double dlina;
        protected Figura(double v, double d)
        {
            visota = v;
            dlina = d;
        }
        public string pl()
        {
            return Convert.ToString(visota * dlina);
        }
    }
}
