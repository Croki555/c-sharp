namespace _11_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button1.Visible = true;
            button5.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            button3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label4.Visible = true;
            label3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label1.Visible = true;
            label3.Visible = true;
            label2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button11.Size = new Size(50, 20);
            button12.Size = new Size(50, 20);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = button14.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = button15.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Готов к работе";
            textBox1.BackColor = Color.Yellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {           
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Size = new Size(50, 50);
            textBox3.Size = new Size(50, 50);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "№2";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "№3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label5.Text = textBox4.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Size = new Size(50, 50);
            label5.Text = "Начало работы";
            label5.BackColor = Color.Green;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = "Мина!";
            button21.BackColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = "Мина!";
            button22.BackColor = Color.Red;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = "Мина!";
            button25.BackColor = Color.Red;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Text = "Мина!";
            button26.BackColor = Color.Red;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Green;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Green;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Text = "Мина!";
            button27.BackColor = Color.Red;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.Green;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.Green;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Size = new Size(100, 40);
            button30.Location = new Point(button30.Location.X, button30.Location.Y - 20);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Size = new Size(100, 40);
            button31.Location = new Point(button31.Location.X + 20,button31.Location.Y);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Size = new Size(100, 40);
            button33.Location = new Point(button33.Location.X - 20, button31.Location.Y);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Size = new Size(100, 40);
            button32.Location = new Point(button32.Location.X, button32.Location.Y + 20);
        }
    }
}