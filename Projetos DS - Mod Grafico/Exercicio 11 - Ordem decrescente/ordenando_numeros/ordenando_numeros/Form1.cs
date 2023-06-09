using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenando_numeros
{
    public partial class Form1 : Form
    {
        int ent1, ent2, ent3, ent4, ent5;

        int[] posicao = new int[5];


        #region "Entrada de dados"
        private void btn_executa_Click(object sender, EventArgs e)
        {
            try
            {
                posicao[0] = int.Parse(txt_num1.Text);
                posicao[1] = int.Parse(txt_num2.Text);
                posicao[2] = int.Parse(txt_num3.Text);
                posicao[3] = int.Parse(txt_num4.Text);
                posicao[4] = int.Parse(txt_num5.Text);
                Executar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n Os números entrados não estao corretos...\nTente novamente....", "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 'fechar'

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }
        #endregion

        #region 'limpar'
        private void btn_apaga_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            txt_num3.Clear();
            txt_num4.Clear();
            txt_num5.Clear();

            txt_result1.Clear();
            txt_result2.Clear();
            txt_result3.Clear();
            txt_result4.Clear();
            txt_result5.Clear();
        }

        
        #endregion

        #region 'Executar'
        public void Executar()
        {
            Array.Sort(posicao);
            Array.Reverse(posicao);

            txt_result1.Text = posicao[0].ToString();
            txt_result2.Text = posicao[1].ToString();
            txt_result3.Text = posicao[2].ToString();
            txt_result4.Text = posicao[3].ToString();
            txt_result5.Text = posicao[4].ToString();
        }


        #endregion

        #region 'Executar ordem crescente'

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Array.Sort(posicao);

                txt_result1.Text = posicao[0].ToString();
                txt_result2.Text = posicao[1].ToString();
                txt_result3.Text = posicao[2].ToString();
                txt_result4.Text = posicao[3].ToString();
                txt_result5.Text = posicao[4].ToString();
            }
        }

        #endregion

        #region 'tecla enter'

        private void txt_num1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_num2.Focus();
            }
        }

        private void txt_num2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_num3.Focus();
            }
        }


        private void txt_num3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_num4.Focus();
            }
        }

        private void txt_num4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txt_num5.Focus();
            }
        }



        private void txt_num5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_executa.Focus();
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
