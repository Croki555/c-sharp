using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chetug ct = new Chetug(comboBox1.Text, double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            MessageBox.Show(ct.inf() + "  с площадью " + ct.pl());
        }
    }
}
