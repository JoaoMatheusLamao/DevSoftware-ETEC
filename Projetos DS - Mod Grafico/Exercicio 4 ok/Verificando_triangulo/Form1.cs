using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificando_triangulo
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
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, valor3;

            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            valor3 = double.Parse(textBox3.Text);

            if ((valor1 + valor2) > valor3 && (valor2 + valor3) > valor1 && (valor3 + valor1) > valor2)
            {
                if (valor1 == valor2 && valor2 == valor3)
                {
                    MessageBox.Show
                        (
                            "O trinângulo é Equilátero",
                            "Resultado"
                        );
                }
                else
                {
                    if (valor1 != valor2 && valor2 != valor3 && valor3 != valor1)
                    {
                        MessageBox.Show
                            (
                                "O triângulo é Escaleno",
                                "Resultado"
                            );
                    }
                    else
                    {
                        MessageBox.Show
                            (
                                "O triângulo é Isóceles",
                                "Resultado"
                            );
                    }
                }
            }
            else
            {
                MessageBox.Show
                    (
                        "Os valores informados não formam um triângulo",
                        "ERRO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
        }
    }
}
