using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_cadastro = new frm_cadastrarProdutos(null, null);
            frm_cadastro.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_Busca = new frm_buscaProduto();
            frm_Busca.Show();
        }
    }
}
