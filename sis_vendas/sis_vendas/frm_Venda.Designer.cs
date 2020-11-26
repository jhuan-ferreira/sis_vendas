namespace sis_vendas
{
    partial class frm_Venda
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
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_idProduto = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_Qtd = new System.Windows.Forms.TextBox();
            this.txt_valorFrete = new System.Windows.Forms.TextBox();
            this.dgv_vendaProduto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_Adiciona = new System.Windows.Forms.Button();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(190, 22);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.ReadOnly = true;
            this.txt_Descricao.Size = new System.Drawing.Size(248, 20);
            this.txt_Descricao.TabIndex = 100;
            // 
            // txt_idProduto
            // 
            this.txt_idProduto.Location = new System.Drawing.Point(82, 22);
            this.txt_idProduto.Name = "txt_idProduto";
            this.txt_idProduto.Size = new System.Drawing.Size(70, 20);
            this.txt_idProduto.TabIndex = 1;
            this.txt_idProduto.LostFocus += new System.EventHandler(this.txt_idProduto_LostFocus);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(353, 59);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(107, 20);
            this.txt_Valor.TabIndex = 4;
            this.txt_Valor.LostFocus += new System.EventHandler(this.txt_Valor_LostFocus);
            // 
            // txt_Qtd
            // 
            this.txt_Qtd.Location = new System.Drawing.Point(469, 22);
            this.txt_Qtd.Name = "txt_Qtd";
            this.txt_Qtd.Size = new System.Drawing.Size(55, 20);
            this.txt_Qtd.TabIndex = 2;
            this.txt_Qtd.LostFocus += new System.EventHandler(this.txt_Qtd_LostFocus);
            // 
            // txt_valorFrete
            // 
            this.txt_valorFrete.Location = new System.Drawing.Point(122, 59);
            this.txt_valorFrete.Name = "txt_valorFrete";
            this.txt_valorFrete.Size = new System.Drawing.Size(89, 20);
            this.txt_valorFrete.TabIndex = 3;
            // 
            // dgv_vendaProduto
            // 
            this.dgv_vendaProduto.AllowUserToAddRows = false;
            this.dgv_vendaProduto.AllowUserToDeleteRows = false;
            this.dgv_vendaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_vendaProduto.Location = new System.Drawing.Point(12, 102);
            this.dgv_vendaProduto.Name = "dgv_vendaProduto";
            this.dgv_vendaProduto.ReadOnly = true;
            this.dgv_vendaProduto.Size = new System.Drawing.Size(692, 192);
            this.dgv_vendaProduto.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProduto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor do Produto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor do Frete";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Location = new System.Drawing.Point(629, 303);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Finalizar.TabIndex = 6;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Location = new System.Drawing.Point(588, 59);
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(116, 23);
            this.btn_Adiciona.TabIndex = 5;
            this.btn_Adiciona.Text = "Adicionar ao Carrinho";
            this.btn_Adiciona.UseVisualStyleBackColor = true;
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.Location = new System.Drawing.Point(411, 301);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(105, 24);
            this.lbl_ValorTotal.TabIndex = 101;
            this.lbl_ValorTotal.Text = "Valor Total:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(522, 301);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 24);
            this.lbl_Total.TabIndex = 102;
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 335);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.btn_Adiciona);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.dgv_vendaProduto);
            this.Controls.Add(this.txt_valorFrete);
            this.Controls.Add(this.txt_Qtd);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_idProduto);
            this.Controls.Add(this.txt_Descricao);
            this.Name = "frm_Venda";
            this.Text = "frm_Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.TextBox txt_idProduto;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_Qtd;
        private System.Windows.Forms.TextBox txt_valorFrete;
        private System.Windows.Forms.DataGridView dgv_vendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_Adiciona;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label lbl_Total;
    }
}