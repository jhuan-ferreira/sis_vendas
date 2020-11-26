using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_Venda : Form
    {
        sisVendasContext dbContext = new sisVendasContext();
        Produto produto = new Produto();
        Cliente cliente = new Cliente();

        public frm_Venda(Cliente cliente)
        {
            this.cliente = cliente;

            InitializeComponent();
        }

        private void txt_idProduto_LostFocus(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_idProduto.Text);

                produto = dbContext.Produtos.Where(p => p.ProdutoId == id).First();

                txt_Descricao.Text = produto.Nome;

                double valor = Convert.ToDouble(produto.Valor);
                txt_Valor.Text = string.Format("{0:c}", valor);
            }

            catch
            {
               
                MessageBox.Show("Produto/Serviço não encontrado !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            crudVendas crudVendas = new crudVendas();
            crudVendas.efetivaVenda(dgv_vendaProduto, double.Parse(lbl_Total.Text), decimal.Parse(txt_valorFrete.Text), cliente);

        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            var index = dgv_vendaProduto.Rows.Add();

            dgv_vendaProduto.Rows[index].Cells[0].Value = txt_idProduto.Text;
            dgv_vendaProduto.Rows[index].Cells[1].Value = txt_Descricao.Text;
            dgv_vendaProduto.Rows[index].Cells[2].Value = txt_Valor.Text;
            dgv_vendaProduto.Rows[index].Cells[3].Value = txt_Qtd.Text;

            decimal cont = +decimal.Parse(txt_Valor.Text.Replace("R$", ""));

            if (lbl_Total.Text == "")
            {
                lbl_Total.Text = "0";
            }

            lbl_Total.Text = Convert.ToString(decimal.Parse(lbl_Total.Text) + cont);

            txt_idProduto.Text = string.Empty;
            txt_Descricao.Text = string.Empty;
            txt_Qtd.Text = string.Empty;
            txt_Valor.Text = string.Empty;
            
        }

        private void txt_Valor_LostFocus(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txt_Valor.Text.Replace("R$", ""));
            txt_Valor.Text = string.Format("{0:c}", valor);
        }

        private void txt_Qtd_LostFocus(object sender, EventArgs e)
        {
            if (txt_Qtd.Text != string.Empty)
            {

                txt_Valor.Text = string.Format("{0:c}", produto.Valor * int.Parse(txt_Qtd.Text));
            }

            else
            {
                return;
            }

        }



    }
}
