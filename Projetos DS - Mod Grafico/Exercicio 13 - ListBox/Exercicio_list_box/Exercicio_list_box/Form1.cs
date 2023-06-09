using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_list_box
{
    public partial class Form1 : Form
    {
        string nome_produto;
        int cod_produto;
        float valor_produto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 'Apagar textBox'
        public void cancelar()
        {
            txt_codProduto.Clear();
            txt_nomeProduto.Clear();
            txt_valorProduto.Clear();

            txt_codProduto.Focus();
        }
        #endregion

        #region 'Bt_Cancelar'
        private void button2_Click(object sender, EventArgs e)
        {
            cancelar();
        }
        #endregion

        #region 'Saida'
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Saida final = new Saida();
            final.fim();
        }

        #endregion

        #region 'Executar'

        public void Executar()
        {
            if (cod_produto == 0)
            {
                MessageBox.Show
                    (
                    "O produto não está disponível!",
                    "Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                cancelar();
            }
            else
            {
                listBox1.Items.Add(nome_produto);
                cancelar();
            }
        }
        #endregion

        #region 'Verificar'
        private void bt_addItem_Click(object sender, EventArgs e)
        {
            try
            {
                nome_produto = txt_nomeProduto.Text;
                cod_produto = int.Parse(txt_codProduto.Text);
                valor_produto = float.Parse(txt_valorProduto.Text);

                Executar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + "\n Tente novamente!!!",
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                cancelar();
            }
        }
        #endregion

        #region 'Apagar Item'
        private void bt_apagaItem_Click(object sender, EventArgs e)
        {
            int posicao_lista = listBox1.SelectedIndex;
            if (posicao_lista == -1)
            {
                MessageBox.Show("Selecione um ítem para ser excluído!",
                    "Excluindo Ítems",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.RemoveAt(posicao_lista);
                txt_codProduto.Focus();
            }
        }
        #endregion

        #region 'Limpar lista'
        private void bt_limpaLista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_codProduto.Focus();
        }
        #endregion
    }
}
