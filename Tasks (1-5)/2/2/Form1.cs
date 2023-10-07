using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = $"{textBox1.Text.Length}";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Clear();
        }
        private void textBox1_Click(object sender, EventArgs e) { textBox1.Clear();  textBox1.Paste(); }
    }
}
