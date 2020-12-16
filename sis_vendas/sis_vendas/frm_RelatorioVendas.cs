using System;
using System.Windows.Forms;
using Correios;

namespace sis_vendas
{
    public partial class frm_RelatorioVendas : Form
    {
        CorreiosApi CorreiosApi = new CorreiosApi();

        public frm_RelatorioVendas()
        {
            InitializeComponent();
        }


        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdnBtnBairro.Checked)
                {
                    var cep = CorreiosApi.consultaCEP(txtCep.Text);

                    this.DataTable1TableAdapter.FillBuscaVendaPorBairro(this.dtsetVendas.DataTable1, Convert.ToString(dtPickerDataInicial.Value.Date), Convert.ToString(dtPickerDataFinal.Value), cep.bairro);
                    this.rptViewVendas.RefreshReport();
                }


                else if (rdnBtnEstado.Checked)
                {
                    this.DataTable1TableAdapter.FillBuscaVendaPorUF(this.dtsetVendas.DataTable1, Convert.ToString(dtPickerDataInicial.Value.Date), Convert.ToString(dtPickerDataFinal.Value.Date), txtUf.Text);

                    this.rptViewVendas.RefreshReport();
                }
            }

            catch
            {
                MessageBox.Show("Não foi possível gerar o relatório, por favor verifique os campos e os dados inseridos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rdnBtnCep_CheckedChanged(object sender, EventArgs e)
        {
                txtCep.ReadOnly = false;
                txtCep.Focus();
        }

        private void rdnBtnBairro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnBairro.Checked)
            {
                txtCep.ReadOnly = false;
                txtUf.ReadOnly = true;
                txtCep.Focus();
            }
        }

        private void rdnBtnEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnEstado.Checked)
            {
                txtCep.ReadOnly = true;
                txtUf.ReadOnly = false;
                txtUf.Focus();
            }
        }




    }
}
