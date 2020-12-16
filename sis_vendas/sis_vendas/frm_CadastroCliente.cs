using System;
using System.Windows.Forms;
using Correios;

namespace sis_vendas
{
    public partial class frm_CadastroCliente : Form
    {

        sisVendasContext dbContext = new sisVendasContext();

        public frm_CadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Você realmente deseja cadastrar este Cliente/Fornecedor ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    crudCliente crudCliente = new crudCliente();
                    crudEndereco crudEndereco = new crudEndereco();

                    crudEndereco.adicionaLogadouro(txt_Endereco.Text, txt_Bairro.Text, txt_Estado.Text, txt_Cidade.Text, txt_Cep.Text, int.Parse(txt_Numero.Text));
                    crudCliente.adicionarCliente(txt_Nome.Text, txt_Telefone.Text, txt_Email.Text, txt_Endereco.Text, txt_Documento.Text);

                    LimpaCampos();
                }

            }

            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro deste Cliente/Fornecedor");
                LimpaCampos();
            }
        }

        private void rdButton_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_Documento.Text = string.Empty;
            txt_Documento.Focus();
            txt_Documento.Mask = rdButton_Cpf.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }

        private void txt_Cep_Focus(object sender, EventArgs e)
        {
            txt_Cep.SelectionStart = 0;
            txt_Cep.Mask = @"00000-000";
        }

        private void txt_Cep_Leave(object sender, EventArgs e)
        {
            try
            {
                LocalizarCEP();
                txt_Numero.Focus();
            }

            catch
            {
                MessageBox.Show("Cep Inválido !");
                txt_Cep.Text = string.Empty;
            }

        }


        private void LocalizarCEP()
        {
            CorreiosApi correios = new CorreiosApi();

            if (!string.IsNullOrEmpty(txt_Cep.Text.Replace("-", "")) && !string.IsNullOrWhiteSpace(txt_Cep.Text.Replace("-", "")))
            {
                var cep = correios.consultaCEP(txt_Cep.Text);

                crudEndereco crudEndereco = new crudEndereco();

                crudEndereco.adicionaEstado(cep.uf);
                crudEndereco.adicionarBairro(cep.bairro);
                crudEndereco.adicionarCidade(cep.cidade);

                txt_Bairro.Text = cep.bairro;
                txt_Estado.Text = cep.uf;
                txt_Cidade.Text = cep.cidade;
                txt_Endereco.Text = cep.end;
            }

            else
            {
                MessageBox.Show("O Cep inserido não está válido ou não foi encontrado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void LimpaCampos()
        {
            txt_Nome.Text = string.Empty;
            txt_Telefone.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Documento.Text = string.Empty;
            txt_Cep.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_Endereco.Text = string.Empty;
            txt_Estado.Text = string.Empty;
            txt_Numero.Text = string.Empty;
            txt_Cidade.Text = string.Empty;
        }

        private void txt_Cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }


}
