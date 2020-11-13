using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_cadastraProduto : Form
    {
        sisVendasContext dbContext = new sisVendasContext();

        Produto produto = new Produto();

        crudProduto crudProduto = new crudProduto();

        bool? x;

        public frm_cadastraProduto(bool? x, Produto produto)
        {
            this.x = x;
            this.produto = produto;

            InitializeComponent();
        }

        private void frm_cadastrarProdutos_Load(object sender, EventArgs e)
        {
            cbx_Categoria.DataSource = dbContext.Categoria.Select(p => p.Nome).ToList();

            cbx_Categoria.Text = "Selecione";

            preencheDgv();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                crudProduto.adicionaProduto(txt_nome.Text, cbx_Categoria.SelectedItem.ToString(), decimal.Parse(txt_Valor.Text.Replace("R$ ", "")), int.Parse(txt_qtd.Text));

                limpaFormulario();

                preencheDgv();
            }

            catch
            {
                MessageBox.Show("Não, foi possível cadastrar este produto. Por favor verifique os campos");
            }
        }

        private void limpaFormulario()
        {
            txt_nome.Text = string.Empty;
            txt_qtd.Text = string.Empty;
            txt_Valor.Text = string.Empty;
        }

        private void preencheDgv()
        {
            dgv_cadastrosProdutos.DataSource = dbContext.Produto.ToList();
        }

        private void txt_Valor_LostFocus(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txt_Valor.Text.Replace("R$ ", ""));
                txt_Valor.Text = string.Format("{0:c}", valor);
            }

            catch
            {
                txt_Valor.Text = "";

                MessageBox.Show("Valor invalido !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    }
}

