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
        int one = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Visible == false)
            {
                label1.Visible = true;
                if(one == 1)
                {
                    label1.ForeColor = Color.Red;
                }
            } else
            {                             
                label1.Visible = false;
                one = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
           
        }
    }
}
