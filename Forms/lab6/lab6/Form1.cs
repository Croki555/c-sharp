namespace lab6
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
            int index = listBox1.SelectedIndex;
            string str = listBox1.Items[index].ToString();
            int zero = 0;
            int one = 0;
            int signs = 0;
            for(int i = 0; i < str.Length; i++)
            {
                str.ToCharArray();
                if(str[i] == ',' | str[i] == '.') { signs++; }
                if(str[i] == '0')
                {
                    zero++;
                } else if (str[i] == '1')
                {
                    one++;
                }
            }
            string[] words;
            words = str.Split(',', ' ');
            List<string> numbers = new List<string>();
            List<char> sym = new List<char>();
            if (index == 0)
            {
                textBox1.Clear();
                textBox1.Text += $"Количество единиц = {one}, нулей = {zero}" + Environment.NewLine;
            } else if (index == 1)
            {
                textBox1.Clear();
                textBox1.Text += $"Количество слов = {words.Length}" + Environment.NewLine;
                textBox1.Text += $"Количество знаков препинания = {signs}" + Environment.NewLine;
            } else if (index == 2)
            {
                for(int i = 0; i < str.Length;i++)
                {
                    str.ToCharArray();
                    if(char.IsNumber(str[i])) {
                        numbers.Add(str[i].ToString());
                    }
                }
                textBox1.Clear();
                foreach(string num in numbers)
                {
                    textBox1.Text += $"{num}";
                }
            } else if (index == 3)
            {
                textBox1.Clear();
                for(int i = 0; i < str.Length; i++)
                {
                    str.ToCharArray();
                    
                        if(char.IsPunctuation(str[i]) & (i % 2 == 0))
                        {
                            sym.Add(str[i]);
                        }
                }
                sym.Reverse();

                textBox1.Text += "В обратном порядке знаки препинания на чётных местах: ";
                string t = "";
                foreach (char s in sym)
                {
                    t += $"{s}";
                }
                textBox1.Text += t + Environment.NewLine;
                sym.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    str.ToCharArray();

                    if (char.IsPunctuation(str[i]) & (i % 2 == 0))
                    {
                        sym.Add(str[i]);
                    }
                }
                textBox1.Text += "Символы на чётных местах: ";
                t = "";
                foreach (char s in sym)
                {
                    t += $"{s}";
                }
                textBox1.Text += t + Environment.NewLine;
                sym.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    str.ToCharArray();
                    if (char.IsPunctuation(str[i]) && (i % 2 != 0))
                    {
                        sym.Add(str[i]);
                    }
                }
                textBox1.Text += "Символы на нечётных местах: ";
                t = "";

                foreach (char s in sym)
                {
                    t+= $"{s}";
                }
                textBox1.Text += t + Environment.NewLine;
            } else if (index == 4)
            {
                textBox1.Clear();
                str.ToCharArray();
                for(int i = 0; i < str.Length; i++)
                {
                    if(char.IsNumber(str[i]) && str[i] % 2 ==0)
                    {
                        textBox1.Text += str[i];
                    }
                }
            } else if (index == 5)
            {
                textBox1.Clear();
                string st = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                //string st2 = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZ";
                str.ToCharArray();
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if(st.Contains(str[i]))
                    {
                        count++;
                    }
                }
                textBox1.Text = $"Количество строчных русских букв = {count}";
            }   
        }
    }
}