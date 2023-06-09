using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num;

            num = float.Parse(textBox1.Text);

            if (num > 0)
            {
                MessageBox.Show
                    (
                    "O número inserido é positivo e seu quadrado é " + Math.Pow(num, 2),
                    "Número positivo",
                    MessageBoxButtons.OK
                    );
            }
            else
            {
                MessageBox.Show
                    (
                    "O número inserido é negativo",
                    "Número Negativo",
                    MessageBoxButtons.OK
                    );
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
