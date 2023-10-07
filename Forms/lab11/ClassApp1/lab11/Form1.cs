using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(textBox1.Text,(int)numericUpDown1.Value);
            MessageBox.Show(worker.Print());
            worker.SetEat(15);
            MessageBox.Show(worker.Print());
            worker.Ves = 20;
            MessageBox.Show(worker.Print());
        }
    }
}
