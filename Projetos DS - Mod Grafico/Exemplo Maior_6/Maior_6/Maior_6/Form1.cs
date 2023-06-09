using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_6
{
    public partial class FrmMaiorde6 : Form
    {
        int N1, N2, N3, N4, N5, N6, maior=0;
        string mensagem = "";


        private void btSair_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            Cancelar();
        }


        #region 'função tecla enter'

        private void Txtn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Txtn2.Focus();
            }
        }

        private void Txtn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Txtn3.Focus();
            }
        }

        private void Txtn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Txtn4.Focus();
            }
        }


        private void Txtn4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Txtn5.Focus();
            }
        }

        private void Txtn5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Txtn_6.Focus();
            }
        }

        private void Txtn_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btVerifica.Focus();
            }
        }
        #endregion


        public FrmMaiorde6()
        {
            InitializeComponent();
        }

        private void FrmMaiorde6_Load(object sender, EventArgs e)
        {

        }

        #region "Entrada de dados"
        private void btVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                N1 = int.Parse(Txtn1.Text);
                N2 = int.Parse(Txtn2.Text);
                N3 = int.Parse(Txtn3.Text);
                N4 = int.Parse(Txtn4.Text);
                N5 = int.Parse(Txtn5.Text);
                N6 = int.Parse(Txtn_6.Text);
                Testar();
                Lblresultado.Text = mensagem;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n Sequência de entrada não está no formato correto...\nTente novamente...", "****ERRO****",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Cancelar();
            }
        }
        #endregion

        #region "procedimento testar"
        public void Testar()
        {
            if (N1>N2 && N1>N3 && N1>N4 && N1 > N5 && N1 > N6)
            {
                maior = N1;
                mensagem = "O maior número é " + maior.ToString();
            }
            else
            {
                if (N2 > N1 && N2 > N3 && N2 > N4 && N2 > N5 && N2 > N6)
                {
                    maior = N2;
                    mensagem = "O maior número é " + maior.ToString();
                }
                else
                {
                    if (N3 > N1 && N3>N2 && N3 > N4 && N3 > N5 && N3 > N6)
                    {
                        maior = N3;
                        mensagem = "O maior número é " + maior.ToString();
                    }
                    else
                    {
                        if (N4 > N1 && N4 > N2 && N4 > N3 && N4 > N5 && N4 > N6)
                        {
                            maior = N4;
                            mensagem = "O maior número é " + maior.ToString();
                        }
                        else
                        {
                            if (N5 > N1 && N5 > N2 && N5 > N3 && N5 > N4 && N5 > N6)
                            {
                                maior = N5;
                                mensagem = "O maior número é " + maior.ToString();
                            }
                            else
                            {
                                if (N6 > N1 && N6 > N2 && N6 > N3 && N6 > N4 && N6 > N5)
                                {
                                    maior = N6;
                                    mensagem = "O maior número é " + maior.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region "procedimento cancelar"
        public void Cancelar()
        {
            Txtn1.Clear();
            Txtn2.Clear();
            Txtn3.Clear();
            Txtn4.Clear();
            Txtn5.Clear();
            Txtn_6.Clear();

            mensagem = "";
        }
        #endregion
    }
}
