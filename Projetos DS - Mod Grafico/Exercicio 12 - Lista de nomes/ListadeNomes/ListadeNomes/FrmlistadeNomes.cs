using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadeNomes
{
    public partial class FrmlistadeNomes : Form
    {
        public FrmlistadeNomes()
        {
            InitializeComponent();
        }

        private void FrmlistadeNomes_Load(object sender, EventArgs e)
        {
            btRemove.Enabled = false;
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lstNome.Items.Add(nome.ToUpper());
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int valor = lstNome.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Para excluir um item da lista \n é necessário primeiro seleciona-lo",
                    "Excluindo item da lista",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btRemove.Enabled = false;
                txtNome.Focus();
            }
            else
            {
                lstNome.Items.RemoveAt(valor);
            }
        }

        private void btRemoveTudo_Click(object sender, EventArgs e)
        {
            if (lstNome.Items.Count == 0)
            {
                MessageBox.Show("A lista está vazia !!! \n Adicione o primeiro item \n e depois selecione para removê-lo",
                    "Excluindo item da lista",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                btRemove.Enabled = false;
                lstNome.Items.Clear();
                txtNome.Focus();
            }
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "Finalizando programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btRemove.Enabled = false;
        }

        private void lstNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRemove.Enabled = true;
        }
    }
}
