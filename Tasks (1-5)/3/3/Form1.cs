using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void Key(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            char[] s = textBox1.Text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if(c == s[i])
                {
                    e.Handled = true;
                } else
                {
                    e.Handled = false;
                }
            }
        }
    }
}
