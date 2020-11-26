namespace sis_vendas
{
    partial class frm_BuscaProduto
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Busca = new System.Windows.Forms.Button();
            this.dgv_Produtos = new System.Windows.Forms.DataGridView();
            this.menuStrip_DgvProdutos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripItem_Atualiza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            this.menuStrip_DgvProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(52, 23);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(189, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(22, 26);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 13);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "ID :";
            // 
            // btn_Busca
            // 
            this.btn_Busca.Location = new System.Drawing.Point(257, 17);
            this.btn_Busca.Name = "btn_Busca";
            this.btn_Busca.Size = new System.Drawing.Size(55, 30);
            this.btn_Busca.TabIndex = 2;
            this.btn_Busca.Text = "Buscar";
            this.btn_Busca.UseVisualStyleBackColor = true;
            this.btn_Busca.Click += new System.EventHandler(this.btn_Busca_Click);
            // 
            // dgv_Produtos
            // 
            this.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produtos.ContextMenuStrip = this.menuStrip_DgvProdutos;
            this.dgv_Produtos.Location = new System.Drawing.Point(12, 68);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.Size = new System.Drawing.Size(599, 200);
            this.dgv_Produtos.TabIndex = 3;
            // 
            // menuStrip_DgvProdutos
            // 
            this.menuStrip_DgvProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItem_Atualiza,
            this.menuStripItem_Delete});
            this.menuStrip_DgvProdutos.Name = "menuStrip_dgv";
            this.menuStrip_DgvProdutos.Size = new System.Drawing.Size(167, 48);
            // 
            // menuStripItem_Atualiza
            // 
            this.menuStripItem_Atualiza.Name = "menuStripItem_Atualiza";
            this.menuStripItem_Atualiza.Size = new System.Drawing.Size(166, 22);
            this.menuStripItem_Atualiza.Text = "Atualizar Produto";
            this.menuStripItem_Atualiza.Click += new System.EventHandler(this.Att_Click);
            // 
            // menuStripItem_Delete
            // 
            this.menuStripItem_Delete.Name = "menuStripItem_Delete";
            this.menuStripItem_Delete.Size = new System.Drawing.Size(166, 22);
            this.menuStripItem_Delete.Text = "Excluir Produto";
            this.menuStripItem_Delete.Click += new System.EventHandler(this.menuStrip_Del_Click);
            // 
            // frm_BuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 280);
            this.Controls.Add(this.dgv_Produtos);
            this.Controls.Add(this.btn_Busca);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_BuscaProduto";
            this.Text = "Buscar Produto";
            this.Load += new System.EventHandler(this.frm_buscaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.menuStrip_DgvProdutos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Busca;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.ContextMenuStrip menuStrip_DgvProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_Atualiza;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_Delete;
    }
}