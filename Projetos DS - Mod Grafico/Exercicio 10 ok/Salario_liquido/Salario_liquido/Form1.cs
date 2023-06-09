using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario_liquido
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
            string nome, cargo;
            double hrs_trabalhadas, valor_hora, desconto, sal_liq, sal_total, por_desconto;
            
            //atribuição das variaveis

            nome = txt_nome.Text;
            cargo = txt_cargo.Text;

            hrs_trabalhadas = double.Parse(txt_horas_trabalhadas.Text);
            valor_hora = double.Parse(txt_valor_hora.Text);
            desconto = double.Parse(txt_desconto.Text);

            //calculo do salario liquido

            sal_total = hrs_trabalhadas * valor_hora;

            por_desconto = desconto / 100;

            sal_liq = sal_total - (sal_total * por_desconto);

            //limpando lista

            lst_relatorio.Items.Clear();

            //verificando op

            if (sal_liq > 1000)
            {
                lst_relatorio.Items.Insert(0, nome);
                lst_relatorio.Items.Insert(1, cargo);
                lst_relatorio.Items.Insert(2, sal_liq);
            }
            else
            {
                MessageBox.Show
                    (
                    "Seu salário líquido é menor que R$ 1000,00",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }

            txt_cargo.Clear();
            txt_desconto.Clear();
            txt_nome.Clear();
            txt_valor_hora.Clear();
            txt_horas_trabalhadas.Clear();

            txt_nome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_cargo.Clear();
            txt_desconto.Clear();
            txt_nome.Clear();
            txt_valor_hora.Clear();
            txt_horas_trabalhadas.Clear();
        }
    }
}
