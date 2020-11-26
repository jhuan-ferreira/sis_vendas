namespace sis_vendas
{
    partial class frm_buscaCliente
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
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.btn_Busca = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.menuStrip_Cliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripItem_Atualiza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.menuStrip_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.ContextMenuStrip = this.menuStrip_Cliente;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 69);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.Size = new System.Drawing.Size(599, 200);
            this.dgv_Cliente.TabIndex = 7;
            // 
            // btn_Busca
            // 
            this.btn_Busca.Location = new System.Drawing.Point(259, 16);
            this.btn_Busca.Name = "btn_Busca";
            this.btn_Busca.Size = new System.Drawing.Size(55, 30);
            this.btn_Busca.TabIndex = 6;
            this.btn_Busca.Text = "Buscar";
            this.btn_Busca.UseVisualStyleBackColor = true;
            this.btn_Busca.Click += new System.EventHandler(this.btn_Busca_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(24, 25);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 13);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "ID :";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(54, 22);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(189, 20);
            this.txt_Id.TabIndex = 4;
            // 
            // menuStrip_Cliente
            // 
            this.menuStrip_Cliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItem_Atualiza,
            this.menuStripItem_Delete});
            this.menuStrip_Cliente.Name = "menuStrip_Cliente";
            this.menuStrip_Cliente.Size = new System.Drawing.Size(181, 70);
            // 
            // menuStripItem_Atualiza
            // 
            this.menuStripItem_Atualiza.Name = "menuStripItem_Atualiza";
            this.menuStripItem_Atualiza.Size = new System.Drawing.Size(180, 22);
            this.menuStripItem_Atualiza.Text = "Atualizar";
            this.menuStripItem_Atualiza.Click += new System.EventHandler(this.menuStripItem_Atualiza_Click);
            // 
            // menuStripItem_Delete
            // 
            this.menuStripItem_Delete.Name = "menuStripItem_Delete";
            this.menuStripItem_Delete.Size = new System.Drawing.Size(120, 22);
            this.menuStripItem_Delete.Text = "Excluir";
            // 
            // frm_buscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 282);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.btn_Busca);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Id);
            this.Name = "frm_buscaCliente";
            this.Text = "frm_buscaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.menuStrip_Cliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.ContextMenuStrip menuStrip_Cliente;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_Atualiza;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_Delete;
        private System.Windows.Forms.Button btn_Busca;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
    }
}