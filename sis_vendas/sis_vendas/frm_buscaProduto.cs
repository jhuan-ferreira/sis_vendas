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

        public frm_buscaProduto()
        {
            InitializeComponent();
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);

            dgv_Produtos.DataSource = dbContext.Produto.Where(p => p.Id == id).ToList();

            txt_Id.Text = string.Empty;
        }

        private void Att_Click(object sender, EventArgs e)
        {
            produto.Id = int.Parse(dgv_Produtos.CurrentRow.Cells[0].Value.ToString());

            Form frm_CadastrarProduto = new frm_cadastrarProdutos(true, produto);
            frm_CadastrarProduto.Show();
        }

        private void frm_buscaProduto_Load(object sender, EventArgs e)
        {
            dgv_Produtos.DataSource = dbContext.Produto.ToList();
        }
    }
}
