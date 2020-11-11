using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_cadastrarProdutos : Form
    {
        sisVendasContext dbContext = new sisVendasContext();

        Produto produto = new Produto();

        bool? x;

        public frm_cadastrarProdutos(bool? x, Produto produto)
        {
            this.x = x;
            this.produto = produto;

            InitializeComponent();
        }

        private void frm_cadastrarProdutos_Load(object sender, EventArgs e)
        {
            if (x == true && Convert.ToString( produto.Id) != null)
            {
                var product = dbContext.Produto.Where(p => p.Id == produto.Id).First();

                txt_nome.Text = product.Nome;
                txt_Valor.Text = Convert.ToString(product.Valor);

                dgv_cadastrosProdutos.Enabled = false;

                dgv_cadastrosProdutos.Visible = false;

                btn_Cadastrar.Text = "Atualizar";
            }

            else
            {
                cbx_Categoria.DataSource = dbContext.Categoria.Select(p => p.Nome).ToList();

                cbx_Categoria.Text = "Selecione";

                dgv_cadastrosProdutos.DataSource = dbContext.Produto.ToList();
            }

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            adicionarProduto adicionar = new adicionarProduto();

            adicionar.adicionarProdutoes(txt_nome.Text, cbx_Categoria.SelectedItem.ToString(), double.Parse(txt_Valor.Text), int.Parse(txt_qtd.Text));

            limpaFormulario();

        }

        private void limpaFormulario()
        {
            txt_nome.Text = string.Empty;
            txt_qtd.Text = string.Empty;
            txt_Valor.Text = string.Empty;
        }

    }
}
