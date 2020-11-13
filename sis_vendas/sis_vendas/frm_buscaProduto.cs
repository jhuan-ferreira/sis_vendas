using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_buscaProduto : Form
    {
        sisVendasContext dbContext = new sisVendasContext();
        Produto produto = new Produto();
        crudProduto crudProduto = new crudProduto();

        public frm_buscaProduto()
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
                dgv_Produtos.DataSource = dbContext.Produto.Where(p => p.Id == id).ToList();
            }

            else if (string.IsNullOrEmpty(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                preencheDgv();
            }

            else
            {
                dgv_Produtos.DataSource = dbContext.Produto.Where(p => p.Nome == txt_Id.Text).ToList();
            }

            txt_Id.Text = string.Empty;
        }

        private void Att_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_Produtos.CurrentRow.Cells[0].Value.ToString());

            produto = dbContext.Produto.Where(p => p.Id == id).First();

            Form frm_AtualizaProduto = new frm_AtualizaProduto(true, produto);
            frm_AtualizaProduto.Show();

            Close();
        }

        private void frm_buscaProduto_Load(object sender, EventArgs e)
        {
            preencheDgv();
        }

        private void menuStrip_Del_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você realmente deseja excluir este produto ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                crudProduto.removerProduto(int.Parse(dgv_Produtos.CurrentRow.Cells[0].Value.ToString()));
                preencheDgv();
            }

            else
            {
                return;
            }

        }

        private void preencheDgv()
        {
            dgv_Produtos.DataSource = dbContext.Produto.ToList();
        }

    }
}