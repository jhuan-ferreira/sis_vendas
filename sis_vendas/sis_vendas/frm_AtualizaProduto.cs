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

        public frm_AtualizaProduto(bool? x, Produto produto)
        {
            this.x = x;

            this.produto = produto;

            InitializeComponent();
        }


        private void frm_AtualizaProduto_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(produto.Id) != null)
            {
                cbx_Categoria.DataSource = dbContext.Categoria.Select(p => p.Nome).ToList();

                var product = dbContext.Produto.Where(p => p.Id == produto.Id).First();

                txt_Nome.Text = product.Nome;
                txt_Valor.Text = Convert.ToString(product.Valor);

                cbx_Categoria.Text = Convert.ToString(dbContext.Categoria.Where(p => p.categoriaId == produto.categoriaId).Select(p => p.Nome).First());

            }
        }

        private void btn_Atualiza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja atualizar este produto ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                atualizarProduto atualizaProduto = new atualizarProduto();

                atualizaProduto.attProduto(produto, txt_Nome.Text, double.Parse(txt_Valor.Text), cbx_Categoria.SelectedItem.ToString());

                Close();
            }

            else
            {
                Close();
            }

        }
    }
}
