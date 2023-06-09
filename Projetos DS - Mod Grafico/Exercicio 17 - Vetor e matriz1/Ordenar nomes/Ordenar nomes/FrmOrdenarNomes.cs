using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenar_nomes
{
    public partial class FrmOrdenarNomes : Form
    {
        public FrmOrdenarNomes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region 'Fechar'
        private void btFechar_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }
        #endregion

        #region classificar nomes
        private void btClassificar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[5];
            string aux;
            nomes[0] = txtnome1.Text;
            nomes[1] = txtnome2.Text;
            nomes[2] = txtnome3.Text;
            nomes[3] = txtnome4.Text;
            nomes[4] = txtnome5.Text;
            for (int j = 0; j <= 4; j++)
            {
                if (nomes[j].Length >= 15)
                {
                    label7.Font = new Font ("Arial Norrow", 10,System.Drawing.FontStyle.Bold);
                }
            }
            //ordenar lista
            for (int i = 0; i <= 4; i++)
            {
                for (int j = i + 1; j <= 4; j++)
                {
                    if (string.CompareOrdinal(nomes[i], nomes[j]) > 0)
                    {
                        aux = nomes[1];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
                }
            }

            //exibir a lista no rotulo de saida

            groupBox2.Visible = true;
            for (int x = 0; x <=4; x++)
            {
                label7.Text += "\n" + nomes[x] + "\n";
            }
        }
        #endregion

        private void btCancela_Click(object sender, EventArgs e)
        {
            txtnome1.Clear();
            txtnome2.Clear();
            txtnome3.Clear();
            txtnome4.Clear();
            txtnome5.Clear();
            txtnome1.Focus();
        }
    }
}
