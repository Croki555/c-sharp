namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dk = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            textBox6.Text = "Работу выполнил ст. Соколов П.А" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dk / 2))
            {
                double y = Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - (b * x));
                textBox6.Text += "x = " + x.ToString() + "; y=" + y.ToString() + Environment.NewLine;
                x = x + dk;
            }
        }
    }
}