using System;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_CadastroCliente : Form
    {

        public frm_CadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            crudCliente crudCliente = new crudCliente();

            crudCliente.adicionarCliente(txt_Nome.Text, txt_Telefone.Text, txt_Email.Text, txt_Endereco.Text, txt_Cpf.Text);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
