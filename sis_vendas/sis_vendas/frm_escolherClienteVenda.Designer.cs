namespace sis_vendas
{
    partial class frm_escolherClienteVenda
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_ClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(228, 67);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_ClienteId
            // 
            this.txt_ClienteId.Location = new System.Drawing.Point(102, 70);
            this.txt_ClienteId.Name = "txt_ClienteId";
            this.txt_ClienteId.Size = new System.Drawing.Size(100, 20);
            this.txt_ClienteId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID/Documento :";
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(12, 22);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.ReadOnly = true;
            this.txt_NomeCliente.Size = new System.Drawing.Size(328, 20);
            this.txt_NomeCliente.TabIndex = 0;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(116, 111);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(107, 41);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // frm_escolherClienteVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 175);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ClienteId);
            this.Controls.Add(this.btn_Buscar);
            this.Name = "frm_escolherClienteVenda";
            this.Text = "frm_escolherClienteVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_ClienteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Button btn_Ok;
    }
}