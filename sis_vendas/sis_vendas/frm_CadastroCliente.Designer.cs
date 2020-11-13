namespace sis_vendas
{
    partial class frm_CadastroCliente
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
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.rdButton_Cnpj = new System.Windows.Forms.RadioButton();
            this.rdButton_Cpf = new System.Windows.Forms.RadioButton();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(65, 63);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(119, 20);
            this.txt_Telefone.TabIndex = 1;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(325, 63);
            this.txt_Endereco.Multiline = true;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(232, 82);
            this.txt_Endereco.TabIndex = 2;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(51, 25);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(232, 20);
            this.txt_Nome.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(51, 103);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(218, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(6, 28);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 5;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(6, 66);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(52, 13);
            this.lbl_Telefone.TabIndex = 6;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(408, 47);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_Endereco.TabIndex = 7;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 106);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 13);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "E-Mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Cpf);
            this.groupBox1.Controls.Add(this.rdButton_Cnpj);
            this.groupBox1.Controls.Add(this.rdButton_Cpf);
            this.groupBox1.Controls.Add(this.lbl_Nome);
            this.groupBox1.Controls.Add(this.lbl_Endereco);
            this.groupBox1.Controls.Add(this.lbl_Email);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Endereco);
            this.groupBox1.Controls.Add(this.lbl_Telefone);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Enabled = false;
            this.txt_Cpf.Location = new System.Drawing.Point(70, 157);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(142, 20);
            this.txt_Cpf.TabIndex = 11;
            // 
            // rdButton_Cnpj
            // 
            this.rdButton_Cnpj.AutoSize = true;
            this.rdButton_Cnpj.Location = new System.Drawing.Point(9, 170);
            this.rdButton_Cnpj.Name = "rdButton_Cnpj";
            this.rdButton_Cnpj.Size = new System.Drawing.Size(52, 17);
            this.rdButton_Cnpj.TabIndex = 10;
            this.rdButton_Cnpj.TabStop = true;
            this.rdButton_Cnpj.Text = "CNPJ";
            this.rdButton_Cnpj.UseVisualStyleBackColor = true;
            // 
            // rdButton_Cpf
            // 
            this.rdButton_Cpf.AutoSize = true;
            this.rdButton_Cpf.Location = new System.Drawing.Point(9, 147);
            this.rdButton_Cpf.Name = "rdButton_Cpf";
            this.rdButton_Cpf.Size = new System.Drawing.Size(45, 17);
            this.rdButton_Cpf.TabIndex = 9;
            this.rdButton_Cpf.TabStop = true;
            this.rdButton_Cpf.Text = "CPF";
            this.rdButton_Cpf.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(544, 252);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 10;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 299);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_CadastroCliente";
            this.Text = "frm_CadastroCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdButton_Cnpj;
        private System.Windows.Forms.RadioButton rdButton_Cpf;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}