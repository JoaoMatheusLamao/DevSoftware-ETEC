using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_da_media
{
    public partial class FrmCalcMedia : Form
    {
        public FrmCalcMedia()
        {
            InitializeComponent();
        }

        #region Codigo do Botao Calcular
        private void btCalculcar_Click(object sender, EventArgs e)
        {
            ClassCalcMedia valores = new ClassCalcMedia();
            double a = new double();
            double b = new double();
            double c = new double();
            double d = new double();
            double valor = new double();

            #region Entrada de dados

            try
            {
                string v1 = txtn1.Text;
                v1 = v1.Replace('.',',');
                a = double.Parse(v1);

                string v2 = txtn2.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = txtn3.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                string v4 = txtn4.Text;
                v4 = v4.Replace('.', ',');
                d = double.Parse(v4);

                if (a < 0 || a > 10 || b < 0 || b > 10 || c < 0 || c > 10 ||d < 0 || d > 10)
                {
                    MessageBox.Show("Entrada de notas inválidas\nDigite-as novamente!!!",
                        "****Notas inválidas****",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    limpar();
                }
                else
                {
                    valor = valores.Processar(a, b, c, d);
                    lblMedia.Text = "A média das notas: " + valor.ToString();
                }
            }
            catch (FormatException erro)
            {
                string mens = erro.Message;
                MessageBox.Show(mens + "\n A Entrada dos dados não está em um formato correto!!! \n Tente novamente...",
                 "*****ERRO * ****",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                limpar();
            }

            #endregion
        }
        #endregion

        #region bt_limpar
        private void btCancela_Click(object sender, EventArgs e)
        {
            limpar();
        }
        #endregion

        #region procedimento limpar
        public void limpar()
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtn4.Clear();
            lblMedia.Text = "";
            txtn1.Focus();
        }
        #endregion

        private void btSair_Click(object sender, EventArgs e)
        {
            ClassSair final = new ClassSair();
            final.fim();
        }
    }
}
