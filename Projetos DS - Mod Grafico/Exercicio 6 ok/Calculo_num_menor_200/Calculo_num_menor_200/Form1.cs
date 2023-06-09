using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_num_menor_200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {

            int i, soma = 0;

            for (i = 0; i <= 201; i++)
            {
                if (i < 201)
                {
                    if (i % 4 == 0)
                    {
                        soma = soma + i;
                    }
                }
            }
            txt_resultado.Visible = true;
            txt_resultado.Text = soma.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Clear();
            txt_resultado.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
