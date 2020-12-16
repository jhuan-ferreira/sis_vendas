namespace sis_vendas
{
    partial class frm_RelatorioVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dtPickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.grpboxPeriodo = new System.Windows.Forms.GroupBox();
            this.grpboxLocalidade = new System.Windows.Forms.GroupBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.rdnBtnEstado = new System.Windows.Forms.RadioButton();
            this.rdnBtnBairro = new System.Windows.Forms.RadioButton();
            this.rdnBtnCep = new System.Windows.Forms.RadioButton();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.rptViewVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsetVendas = new sis_vendas.dtsetVendas();
            this.DataTable1TableAdapter = new sis_vendas.dtsetVendasTableAdapters.DataTable1TableAdapter();
            this.grpboxPeriodo.SuspendLayout();
            this.grpboxLocalidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(472, 118);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dtPickerDataInicial
            // 
            this.dtPickerDataInicial.Location = new System.Drawing.Point(29, 19);
            this.dtPickerDataInicial.Name = "dtPickerDataInicial";
            this.dtPickerDataInicial.Size = new System.Drawing.Size(156, 20);
            this.dtPickerDataInicial.TabIndex = 1;
            // 
            // dtPickerDataFinal
            // 
            this.dtPickerDataFinal.Location = new System.Drawing.Point(29, 61);
            this.dtPickerDataFinal.Name = "dtPickerDataFinal";
            this.dtPickerDataFinal.Size = new System.Drawing.Size(156, 20);
            this.dtPickerDataFinal.TabIndex = 2;
            // 
            // grpboxPeriodo
            // 
            this.grpboxPeriodo.Controls.Add(this.dtPickerDataInicial);
            this.grpboxPeriodo.Controls.Add(this.dtPickerDataFinal);
            this.grpboxPeriodo.Location = new System.Drawing.Point(12, 12);
            this.grpboxPeriodo.Name = "grpboxPeriodo";
            this.grpboxPeriodo.Size = new System.Drawing.Size(235, 101);
            this.grpboxPeriodo.TabIndex = 3;
            this.grpboxPeriodo.TabStop = false;
            this.grpboxPeriodo.Text = "Periodo";
            // 
            // grpboxLocalidade
            // 
            this.grpboxLocalidade.Controls.Add(this.lblUf);
            this.grpboxLocalidade.Controls.Add(this.lblCep);
            this.grpboxLocalidade.Controls.Add(this.rdnBtnEstado);
            this.grpboxLocalidade.Controls.Add(this.rdnBtnBairro);
            this.grpboxLocalidade.Controls.Add(this.rdnBtnCep);
            this.grpboxLocalidade.Controls.Add(this.txtCep);
            this.grpboxLocalidade.Controls.Add(this.txtUf);
            this.grpboxLocalidade.Location = new System.Drawing.Point(288, 17);
            this.grpboxLocalidade.Name = "grpboxLocalidade";
            this.grpboxLocalidade.Size = new System.Drawing.Size(304, 90);
            this.grpboxLocalidade.TabIndex = 4;
            this.grpboxLocalidade.TabStop = false;
            this.grpboxLocalidade.Text = "Localidade";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(158, 54);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(24, 13);
            this.lblUf.TabIndex = 8;
            this.lblUf.Text = "UF:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(136, 27);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(32, 13);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "Cep :";
            // 
            // rdnBtnEstado
            // 
            this.rdnBtnEstado.AutoSize = true;
            this.rdnBtnEstado.Location = new System.Drawing.Point(6, 63);
            this.rdnBtnEstado.Name = "rdnBtnEstado";
            this.rdnBtnEstado.Size = new System.Drawing.Size(112, 17);
            this.rdnBtnEstado.TabIndex = 6;
            this.rdnBtnEstado.TabStop = true;
            this.rdnBtnEstado.Text = "Buscar por Estado";
            this.rdnBtnEstado.UseVisualStyleBackColor = true;
            this.rdnBtnEstado.CheckedChanged += new System.EventHandler(this.rdnBtnEstado_CheckedChanged);
            // 
            // rdnBtnBairro
            // 
            this.rdnBtnBairro.AutoSize = true;
            this.rdnBtnBairro.Location = new System.Drawing.Point(6, 40);
            this.rdnBtnBairro.Name = "rdnBtnBairro";
            this.rdnBtnBairro.Size = new System.Drawing.Size(106, 17);
            this.rdnBtnBairro.TabIndex = 3;
            this.rdnBtnBairro.TabStop = true;
            this.rdnBtnBairro.Text = "Buscar por Bairro";
            this.rdnBtnBairro.UseVisualStyleBackColor = true;
            this.rdnBtnBairro.CheckedChanged += new System.EventHandler(this.rdnBtnBairro_CheckedChanged);
            // 
            // rdnBtnCep
            // 
            this.rdnBtnCep.AutoSize = true;
            this.rdnBtnCep.Location = new System.Drawing.Point(6, 17);
            this.rdnBtnCep.Name = "rdnBtnCep";
            this.rdnBtnCep.Size = new System.Drawing.Size(100, 17);
            this.rdnBtnCep.TabIndex = 2;
            this.rdnBtnCep.TabStop = true;
            this.rdnBtnCep.Text = "Buscar por CEP";
            this.rdnBtnCep.UseVisualStyleBackColor = true;
            this.rdnBtnCep.CheckedChanged += new System.EventHandler(this.rdnBtnCep_CheckedChanged);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(175, 24);
            this.txtCep.Name = "txtCep";
            this.txtCep.ReadOnly = true;
            this.txtCep.Size = new System.Drawing.Size(121, 20);
            this.txtCep.TabIndex = 1;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(198, 50);
            this.txtUf.Name = "txtUf";
            this.txtUf.ReadOnly = true;
            this.txtUf.Size = new System.Drawing.Size(27, 20);
            this.txtUf.TabIndex = 0;
            // 
            // rptViewVendas
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.rptViewVendas.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewVendas.LocalReport.ReportEmbeddedResource = "sis_vendas.rptviewRelatorioVendas.rdlc";
            this.rptViewVendas.Location = new System.Drawing.Point(12, 147);
            this.rptViewVendas.Name = "rptViewVendas";
            this.rptViewVendas.ServerReport.BearerToken = null;
            this.rptViewVendas.Size = new System.Drawing.Size(578, 307);
            this.rptViewVendas.TabIndex = 5;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dtsetVendas;
            // 
            // dtsetVendas
            // 
            this.dtsetVendas.DataSetName = "dtsetVendas";
            this.dtsetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.rptViewVendas);
            this.Controls.Add(this.grpboxLocalidade);
            this.Controls.Add(this.grpboxPeriodo);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Name = "frm_RelatorioVendas";
            this.Text = "frm_RelatorioVendas";
            this.grpboxPeriodo.ResumeLayout(false);
            this.grpboxLocalidade.ResumeLayout(false);
            this.grpboxLocalidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsetVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtPickerDataInicial;
        private System.Windows.Forms.DateTimePicker dtPickerDataFinal;
        private System.Windows.Forms.GroupBox grpboxPeriodo;
        private System.Windows.Forms.GroupBox grpboxLocalidade;
        private System.Windows.Forms.RadioButton rdnBtnBairro;
        private System.Windows.Forms.RadioButton rdnBtnCep;
        private System.Windows.Forms.TextBox txtCep;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewVendas;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.RadioButton rdnBtnEstado;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private dtsetVendas dtsetVendas;
        private dtsetVendasTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}