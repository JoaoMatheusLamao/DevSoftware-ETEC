using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumo_carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distancia = 0, consumo = 0;
            distancia = double.Parse(textBox1.Text);
            // Tipo A
            if (checkBox1.Checked)
            {
                consumo = distancia / 12;
            }

            // Tipo B
            if (checkBox2.Checked)
            {
                consumo = distancia / 9;
            }

            //Tipo C
            if (checkBox3.Checked)
            {
                consumo = distancia / 8;
            }

            textBox2.Text = consumo.ToString();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
