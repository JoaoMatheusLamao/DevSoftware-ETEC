using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desconto_inss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_salario.Clear();
            txt_salario.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double salario, sal_descontado;

            salario = double.Parse(txt_salario.Text);

            if (salario <= 1000)
            {
                MessageBox.Show
                    (
                    "Você está isento!!!\r\nO valor do seu salário permanecerá o mesmo",
                    "Taxa de desconto"
                    );
            }
            if (salario > 1001 && salario < 1800)
            {
                sal_descontado = salario - (salario * 0.2);
                MessageBox.Show
                    (
                    "Sua taxa de desconto é de 20%\r\nSeu salário, com o desconto, é de: R$ " + sal_descontado,
                    "Taxa de desconto"
                    );
            }
            if (salario > 1801 && salario < 2500)
            {
                sal_descontado = salario - (salario * 0.25);
                MessageBox.Show
                    (
                    "Sua taxa de desconto é de 25%\r\nSeu salário, com o desconto, é de: R$ " + sal_descontado,
                    "Taxa de desconto"
                    );
            }
            if (salario > 2501)
            {
                sal_descontado = salario - (salario * 0.3);
                MessageBox.Show
                    (
                    "Sua taxa de desconto é de 30%\r\nSeu salário, com o desconto, é de: R$ " + sal_descontado,
                    "Taxa de desconto"
                    );
            }

        }
    }
}
