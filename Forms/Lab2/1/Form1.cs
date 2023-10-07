using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            textBox4.Text = "Лаб.раб №2 Ст.гр ИВ2К-21-1 Соколов П.А";
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            //1 пример
            /* textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();double z1 = z * 0.01;
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString() + " * 10^-2";
            double t = ((2 * Math.Cos( x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y),2))) * 
                ( 1 + (Math.Pow(z1,2) / 3 - (Math.Pow(z1,2)) / 5));
            textBox4.Text += Environment.NewLine + "T = " + t.ToString();*/

            //2 пример 
            /*textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString() + " * 10^-4";
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString() + " * 10^2";
            double z2 = z * Math.Pow(10, 2);
            double y2 = y * Math.Pow(10, -4);
            double u = ( ((Math.Pow(8 + Math.Pow(Math.Abs(x - y2),2) + 1, (double)1/3))) /
                ((Math.Pow(x,2) + Math.Pow(y2,2) + 2)) ) -
                ( (Math.Exp(Math.Abs(x - y2))) *
                (Math.Pow(((Math.Pow(Math.Tan(z2), 2)) + 1), Convert.ToInt32(x))) );
            textBox4.Text += Environment.NewLine + "U = " + u.ToString();*/

            //3 пример
            /*textBox4.Text += Environment.NewLine + "X = " + x.ToString() + " * 10^-2";
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString() + " * 10^2";
            double x3 = x * Math.Pow(10, -2);
            double z3 = z * Math.Pow(10, 2);
            double v = (1 + Math.Pow(Math.Sin(x3 + y) , 2)) / 
                (Math.Abs(x3 - (2 * y / (1 + Math.Pow(x3,2) * Math.Pow(y , 2))) )) * Math.Pow(x3, Math.Abs(y)) + 
                (  Math.Pow( Math.Cos(Math.Atan(1 / z3)) , 2 )  );
            textBox4.Text += Environment.NewLine + "V = " + v.ToString();*/

            //4 пример
            textBox4.Text += Environment.NewLine + "X = " + x.ToString() + " * 10^4";
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString() + " * 10^-3";
            double x4 = x * Math.Pow(10, 4);
            double z4 = z * Math.Pow(10, -3);
            double w = Math.Pow(Math.Abs(Math.Cos(x4) - Math.Cos(y)) , (1 + 2 * Math.Pow(Math.Sin(y),2)) ) *
                (1 + z4 + (Math.Pow(z4, 2) / 2) + (Math.Pow(z4, 3) / 3) + (Math.Pow(z4, 4) / 4));
            textBox4.Text += Environment.NewLine + "W = " + w.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
