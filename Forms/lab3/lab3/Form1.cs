namespace lab3
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
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double c = 0;
            string z = "";
            if (x - y == 0)
            {
                z = "x - y == 0";
                c = Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Sin(y);
            }
            else if (x - y > 0)
            {
                z = "x - y > 0";
                c = Math.Pow(x - y, 2) + Math.Cos(y);
            }
            else if (x - y < 0)
            {
                z = "x - y < 0";
                c = Math.Pow(y - x, 2) + Math.Tan(y);
            }
            textBox3.Text = "Резульат работы программы" + Environment.NewLine;
            textBox3.Text += $"При X = {x}" + Environment.NewLine;
            textBox3.Text += $"При Y = {y}" + Environment.NewLine;
            textBox3.Text += $"При Z = {z}" + Environment.NewLine;
            textBox3.Text += $"C = {c}" + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}