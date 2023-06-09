using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float r = 0, a, b;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            if (radioButton1.Checked)
            {
                r = a + b;
            }
            if (radioButton2.Checked)
            {
                r = a - b;
            }
            if (radioButton3.Checked)
            {
                r = a * b;
            }
            if (radioButton4.Checked)
            {
                if (b == 0)
                {
                    MessageBox.Show(
                        "Divisão por zero",
                        "ERRO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                else
                {
                    r = a / b;
                }
            }
            textBox3.Text = r.ToString();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
