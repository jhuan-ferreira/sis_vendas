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
    public partial class frm_buscaCliente : Form
    {
        sisVendasContext dbContext = new sisVendasContext();
        Cliente cliente = new Cliente();

        public frm_buscaCliente()
        {
            InitializeComponent();
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            int numero;

            bool result = int.TryParse(txt_Id.Text, out numero);

            if (result)
            {
                int id = int.Parse(txt_Id.Text);
                dgv_Cliente.DataSource = dbContext.Clientes.Where(p => p.ClienteId == id).ToList();
            }

            else if (string.IsNullOrEmpty(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                dgv_Cliente.DataSource = dbContext.Produtos.ToList();
            }

            else
            {
                dgv_Cliente.DataSource = dbContext.Produtos.Where(p => p.Nome == txt_Id.Text).ToList();
            }

            txt_Id.Text = string.Empty;
        }

        private void menuStripItem_Atualiza_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(dgv_Cliente.CurrentRow.Cells[0].Value.ToString());

            //cliente = dbContext.Clientes.Where(p => p.ClienteId == id).First();

            //Form frm_AtualizaCliente = new frm_AtualizaCliente(cliente);
            //frm_AtualizaCliente.Show();

            //Close();
        }
    }
}
