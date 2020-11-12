namespace sis_vendas
{
    partial class frm_AtualizaProduto
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Qtd = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Qtd = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.btn_Atualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(83, 30);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(179, 20);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Qtd
            // 
            this.txt_Qtd.Enabled = false;
            this.txt_Qtd.Location = new System.Drawing.Point(113, 68);
            this.txt_Qtd.Name = "txt_Qtd";
            this.txt_Qtd.Size = new System.Drawing.Size(100, 20);
            this.txt_Qtd.TabIndex = 1;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(308, 30);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 2;
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(298, 68);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cbx_Categoria.TabIndex = 3;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(42, 33);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(268, 33);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 5;
            this.lbl_Valor.Text = "Valor:";
            // 
            // lbl_Qtd
            // 
            this.lbl_Qtd.AutoSize = true;
            this.lbl_Qtd.Location = new System.Drawing.Point(42, 71);
            this.lbl_Qtd.Name = "lbl_Qtd";
            this.lbl_Qtd.Size = new System.Drawing.Size(65, 13);
            this.lbl_Qtd.TabIndex = 6;
            this.lbl_Qtd.Text = "Quantidade:";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(237, 71);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // btn_Atualiza
            // 
            this.btn_Atualiza.Location = new System.Drawing.Point(401, 122);
            this.btn_Atualiza.Name = "btn_Atualiza";
            this.btn_Atualiza.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualiza.TabIndex = 8;
            this.btn_Atualiza.Text = "Atualizar";
            this.btn_Atualiza.UseVisualStyleBackColor = true;
            this.btn_Atualiza.Click += new System.EventHandler(this.btn_Atualiza_Click);
            // 
            // frm_AtualizaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 193);
            this.Controls.Add(this.btn_Atualiza);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Qtd);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.cbx_Categoria);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_Qtd);
            this.Controls.Add(this.txt_Nome);
            this.Name = "frm_AtualizaProduto";
            this.Load += new System.EventHandler(this.frm_AtualizaProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Qtd;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Qtd;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Button btn_Atualiza;
    }
}