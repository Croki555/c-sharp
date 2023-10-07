using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\";
            string subpath = @"test";
            Directory.CreateDirectory($"{path}/{subpath}");
            string filePath = $@"C://test//{textBox1.Text}.txt";
            string text = textBox2.Text;
            FileStream fileStream = File.Open(filePath, FileMode.Create);
            StreamWriter output = new StreamWriter(fileStream);
            output.Write(text);
            output.Close();
        }
       
    }
}
