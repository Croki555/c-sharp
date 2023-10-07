using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Crimson;
            label1.Text = "Начало работы";
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Text = "++++";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "До свидания";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.DarkBlue;
            label4.BackColor = Color.DarkBlue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
            label4.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = textBox2.Text; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox4.Text = "****";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
