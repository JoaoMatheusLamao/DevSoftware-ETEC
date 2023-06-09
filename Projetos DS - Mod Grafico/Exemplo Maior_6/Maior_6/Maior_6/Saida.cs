using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maior_6
{
    class Saida
    {
        public void fim()
        {
            string texto = "Deseja sair do programa de verificação dos números?";
            string titulo = "*****FINALIZANDO*****";

            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
