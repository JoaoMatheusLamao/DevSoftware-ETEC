using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificando_pessoas
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

        private void bt_executar_Click(object sender, EventArgs e)
        {
            int idade, cont;
            string nome;

            nome = (txt_nome.Text);
            idade = int.Parse(txt_idade.Text);
            Visible = true;

            if (rb_feminino.Checked)
            {
                if (idade > 21)
                {
                    lst_nomes.Items.Add(nome);
                }
            }
            txt_nome.Clear();
            txt_idade.Clear();
            txt_nome.Focus();
        }

        private void lst_nomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_idade.Clear();
            txt_nome.Focus();
            lst_nomes.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
