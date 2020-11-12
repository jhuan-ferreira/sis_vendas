namespace sis_vendas
{
    partial class frm_buscaProduto
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
            this.menuStrip_dgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip_Att = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Del = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).BeginInit();
            this.menuStrip_dgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(42, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(189, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(12, 15);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 13);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "ID :";
            // 
            // btn_Busca
            // 
            this.btn_Busca.Location = new System.Drawing.Point(247, 6);
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
            this.dgv_Produtos.ContextMenuStrip = this.menuStrip_dgv;
            this.dgv_Produtos.Location = new System.Drawing.Point(12, 68);
            this.dgv_Produtos.Name = "dgv_Produtos";
            this.dgv_Produtos.Size = new System.Drawing.Size(599, 200);
            this.dgv_Produtos.TabIndex = 3;
            // 
            // menuStrip_dgv
            // 
            this.menuStrip_dgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Att,
            this.menuStrip_Del});
            this.menuStrip_dgv.Name = "menuStrip_dgv";
            this.menuStrip_dgv.Size = new System.Drawing.Size(181, 70);
            // 
            // menuStrip_Att
            // 
            this.menuStrip_Att.Name = "menuStrip_Att";
            this.menuStrip_Att.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Att.Text = "Atualizar Produto";
            this.menuStrip_Att.Click += new System.EventHandler(this.Att_Click);
            // 
            // menuStrip_Del
            // 
            this.menuStrip_Del.Name = "menuStrip_Del";
            this.menuStrip_Del.Size = new System.Drawing.Size(180, 22);
            this.menuStrip_Del.Text = "Excluir Produto";
            // 
            // frm_buscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 280);
            this.Controls.Add(this.dgv_Produtos);
            this.Controls.Add(this.btn_Busca);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_buscaProduto";
            this.Text = "Buscar Produto";
            this.Load += new System.EventHandler(this.frm_buscaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produtos)).EndInit();
            this.menuStrip_dgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Busca;
        private System.Windows.Forms.DataGridView dgv_Produtos;
        private System.Windows.Forms.ContextMenuStrip menuStrip_dgv;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Att;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Del;
    }
}