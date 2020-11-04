namespace sis_vendas
{
    partial class frm_cadastrarProdutos
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.dgv_cadastrosProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastrosProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(56, 6);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(247, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(327, 9);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.AutoSize = true;
            this.lbl_qtd.Location = new System.Drawing.Point(12, 48);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(65, 13);
            this.lbl_qtd.TabIndex = 4;
            this.lbl_qtd.Text = "Quantidade:";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(83, 45);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(100, 20);
            this.txt_qtd.TabIndex = 5;
            this.txt_qtd.TextChanged += new System.EventHandler(this.txt_qtd_TextChanged);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(268, 48);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_categoria.TabIndex = 6;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(330, 45);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_categoria.TabIndex = 7;
            // 
            // dgv_cadastrosProdutos
            // 
            this.dgv_cadastrosProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cadastrosProdutos.Location = new System.Drawing.Point(15, 93);
            this.dgv_cadastrosProdutos.Name = "dgv_cadastrosProdutos";
            this.dgv_cadastrosProdutos.Size = new System.Drawing.Size(599, 168);
            this.dgv_cadastrosProdutos.TabIndex = 8;
            // 
            // frm_cadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 273);
            this.Controls.Add(this.dgv_cadastrosProdutos);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_cadastrarProdutos";
            this.Text = "frm_cadastrarProdutos";
            this.Load += new System.EventHandler(this.frm_cadastrarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadastrosProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.DataGridView dgv_cadastrosProdutos;
    }
}