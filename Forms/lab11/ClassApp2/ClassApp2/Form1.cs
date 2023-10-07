using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)        {        }
        private void button1_Click(object sender, EventArgs e)
        {

            Human one = new Human();
            one.Write(textBox1.Text, (int)numericUpDown1.Value, (double)numericUpDown2.Value);
            one.Eat(2);
            MessageBox.Show(one.Print());
        }
    }
}
