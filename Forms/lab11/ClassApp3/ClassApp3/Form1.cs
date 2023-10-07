using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Shopper one = new Shopper();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                one.Buy(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToInt32(numericUpDown1.Value));
                MessageBox.Show(one.InfoProduct());
            } catch (FormatException)
            {
                MessageBox.Show("Вы ничего не купили!\nЗаполните пожалуйста поля");
            }
           
        }
    }
}
