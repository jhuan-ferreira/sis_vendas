using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_AtualizaProduto : Form
    {
        sisVendasContext dbContext = new sisVendasContext();

        bool? x;

        Produto produto = new Produto();

        crudProduto crudProduto = new crudProduto();

        public frm_AtualizaProduto(bool? x, Produto produto)
        {
            this.x = x;

            this.produto = produto;

            InitializeComponent();
        }


        private void frm_AtualizaProduto_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(produto.ProdutoId) != null)
            {
                cbx_Categoria.DataSource = dbContext.Categorias.Select(p => p.Nome).ToList();

                var product = dbContext.Produtos.Where(p => p.ProdutoId == produto.ProdutoId).First();

                txt_Nome.Text = product.Nome;
                txt_Valor.Text = Convert.ToString(product.Valor);

                cbx_Categoria.Text = Convert.ToString(dbContext.Categorias.Where(p => p.categoriaId == produto.categoriaId).Select(p => p.Nome).First());

            }
        }

        private void btn_Atualiza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja atualizar este produto ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                crudProduto.atualizaProduto(produto, txt_Nome.Text, decimal.Parse(txt_Valor.Text.Replace("R$ ", "")), cbx_Categoria.SelectedItem.ToString());

                Close();
            }

            else
            {
                Close();
            }

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
