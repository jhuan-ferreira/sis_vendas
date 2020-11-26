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
            Form frmCadastro = new frm_CadastraProduto(null, null);
            frmCadastro.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmBusca = new frm_BuscaProduto();
            frmBusca.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCadastroCliente = new frm_CadastroCliente();
            frmCadastroCliente.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEscolherClienteVenda = new frm_escolherClienteVenda();
            frmEscolherClienteVenda.Show();
        }
    }
}
