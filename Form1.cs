using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace String_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int generated = 0;
        bool generate = false;
        private static Random random = new Random();
        public static string GenerateString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            generated = 0;
            generate = true;
            while (generate)
            {
                if (generated >= 10001)
                {
                    generate = false;
                    MessageBox.Show("Generated 10,000 random strings");
                }
                else
                {
                    string generatedString = GenerateString(30);
                    textBox1.AppendText("string string" + generated + " = " + '"' + generatedString + '"' + ";");
                    textBox1.AppendText(Environment.NewLine);
                    generated++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }
    }
}
