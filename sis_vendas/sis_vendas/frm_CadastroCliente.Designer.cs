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
        /// 
        /// 
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.gbx_dadosCadastrais = new System.Windows.Forms.GroupBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Documento = new System.Windows.Forms.MaskedTextBox();
            this.rdButton_Cnpj = new System.Windows.Forms.RadioButton();
            this.rdButton_Cpf = new System.Windows.Forms.RadioButton();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.gbx_dadosCadastrais.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(64, 63);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(125, 20);
            this.txt_Telefone.TabIndex = 2;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(52, 25);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(232, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(51, 103);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(218, 20);
            this.txt_Email.TabIndex = 3;
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
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(6, 106);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 13);
            this.lbl_Email.TabIndex = 8;
            this.lbl_Email.Text = "E-Mail:";
            // 
            // gbx_dadosCadastrais
            // 
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Numero);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Numero);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Telefone);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Estado);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Cep);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Estado);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Cep);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Cidade);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Bairro);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Endereco);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Cidade);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Bairro);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Endereco);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Documento);
            this.gbx_dadosCadastrais.Controls.Add(this.rdButton_Cnpj);
            this.gbx_dadosCadastrais.Controls.Add(this.rdButton_Cpf);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Nome);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Email);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Email);
            this.gbx_dadosCadastrais.Controls.Add(this.lbl_Telefone);
            this.gbx_dadosCadastrais.Controls.Add(this.txt_Nome);
            this.gbx_dadosCadastrais.Location = new System.Drawing.Point(12, 12);
            this.gbx_dadosCadastrais.Name = "gbx_dadosCadastrais";
            this.gbx_dadosCadastrais.Size = new System.Drawing.Size(706, 227);
            this.gbx_dadosCadastrais.TabIndex = 9;
            this.gbx_dadosCadastrais.TabStop = false;
            this.gbx_dadosCadastrais.Text = "Dados Cadastrais";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(661, 63);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(38, 20);
            this.txt_Numero.TabIndex = 7;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(608, 66);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(50, 13);
            this.lbl_Numero.TabIndex = 21;
            this.lbl_Numero.Text = "Numero: ";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(350, 182);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.ReadOnly = true;
            this.txt_Estado.Size = new System.Drawing.Size(40, 20);
            this.txt_Estado.TabIndex = 10;
            // 
            // txt_Cep
            // 
            this.txt_Cep.Location = new System.Drawing.Point(350, 25);
            this.txt_Cep.Name = "txt_Cep";
            this.txt_Cep.Size = new System.Drawing.Size(113, 20);
            this.txt_Cep.TabIndex = 5;
            this.txt_Cep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_Cep_MaskInputRejected);
            this.txt_Cep.GotFocus += new System.EventHandler(this.txt_Cep_Focus);
            this.txt_Cep.Leave += new System.EventHandler(this.txt_Cep_Leave);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(303, 185);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.lbl_Estado.TabIndex = 20;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Location = new System.Drawing.Point(315, 28);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(29, 13);
            this.lbl_Cep.TabIndex = 12;
            this.lbl_Cep.Text = "Cep:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(303, 149);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(43, 13);
            this.lbl_Cidade.TabIndex = 11;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(307, 106);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(37, 13);
            this.lbl_Bairro.TabIndex = 19;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(291, 66);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_Endereco.TabIndex = 18;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(352, 146);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.ReadOnly = true;
            this.txt_Cidade.Size = new System.Drawing.Size(163, 20);
            this.txt_Cidade.TabIndex = 9;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(350, 103);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.ReadOnly = true;
            this.txt_Bairro.Size = new System.Drawing.Size(251, 20);
            this.txt_Bairro.TabIndex = 8;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(351, 63);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.ReadOnly = true;
            this.txt_Endereco.Size = new System.Drawing.Size(251, 20);
            this.txt_Endereco.TabIndex = 6;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Location = new System.Drawing.Point(76, 156);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(151, 20);
            this.txt_Documento.TabIndex = 4;
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
            this.rdButton_Cpf.CheckedChanged += new System.EventHandler(this.rdButton_Cpf_CheckedChanged);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(636, 257);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 11;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 303);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.gbx_dadosCadastrais);
            this.Name = "frm_CadastroCliente";
            this.Text = "frm_CadastroCliente";
            this.gbx_dadosCadastrais.ResumeLayout(false);
            this.gbx_dadosCadastrais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.GroupBox gbx_dadosCadastrais;
        private System.Windows.Forms.RadioButton rdButton_Cnpj;
        private System.Windows.Forms.RadioButton rdButton_Cpf;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox txt_Documento;
        private System.Windows.Forms.MaskedTextBox txt_Cep;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Numero;
    }
}