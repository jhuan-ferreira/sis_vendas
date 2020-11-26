using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    public partial class frm_CadastraProduto : Form
    {
        sisVendasContext dbContext = new sisVendasContext();

        Produto produto = new Produto();

        crudProduto crudProduto = new crudProduto();

        bool? x;

        public frm_CadastraProduto(bool? x, Produto produto)
        {
            this.x = x;
            this.produto = produto;

            InitializeComponent();
        }

        private void frm_cadastrarProdutos_Load(object sender, EventArgs e)
        {
            cbx_Categoria.DataSource = dbContext.Categorias.Select(p => p.Nome).ToList();

            cbx_Categoria.Text = "Selecione";
           
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você Deseja realmente cadastrar este Produto/Serviço", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    crudProduto.adicionaProduto(txt_nome.Text, cbx_Categoria.SelectedItem.ToString(), decimal.Parse(txt_Valor.Text.Replace("R$ ", "")), int.Parse(txt_qtd.Text));

                    limpaFormulario();

                    crudProduto.preencheDgv(dgv_cadastrosProdutos);
                }
            }

            catch
            {
                MessageBox.Show("Não, foi possível cadastrar este Produto/Serviço. Por favor verifique os campos");
            }
        }

        private void limpaFormulario()
        {
            txt_nome.Text = string.Empty;
            txt_qtd.Text = string.Empty;
            txt_Valor.Text = string.Empty;
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

