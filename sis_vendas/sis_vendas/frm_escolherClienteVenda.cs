using System;
using System.Windows.Forms;
using System.Linq;

namespace sis_vendas
{
    public partial class frm_escolherClienteVenda : Form
    {
        sisVendasContext dbContext = new sisVendasContext();
        Cliente cliente = new Cliente();

        public frm_escolherClienteVenda()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_ClienteId.Text, out int id))
                {
                    id = 0;
                }

                cliente = dbContext.Clientes.Where(p => p.ClienteId == id || p.Documento == txt_ClienteId.Text).First();

                txt_NomeCliente.Text = cliente.Nome;
            }

            catch
            {
                MessageBox.Show("Cliente não encontrado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {           
            Form frm_Venda = new frm_Venda(cliente);
            frm_Venda.Show();

            Close();
        }
    }
}
