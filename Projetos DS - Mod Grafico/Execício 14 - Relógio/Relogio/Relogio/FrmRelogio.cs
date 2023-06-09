using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio
{
    public partial class FrmRelogio : Form
    {
        public FrmRelogio()
        {
            InitializeComponent();
        }

        private void FrmRelogio_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
