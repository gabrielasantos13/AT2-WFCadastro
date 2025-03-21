namespace AT2_WFCadastroPessoa
{
    partial class FormCadastro
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
            lblCodigo = new Label();
            mtbCodigo = new MaskedTextBox();
            mkbCPF = new MaskedTextBox();
            lblCPF = new Label();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mtbDddCelular = new MaskedTextBox();
            lblDddCelular = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbPossuiFilhos = new RadioButton();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(31, 41);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(31, 59);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(100, 23);
            mtbCodigo.TabIndex = 1;
            // 
            // mkbCPF
            // 
            mkbCPF.Location = new Point(176, 59);
            mkbCPF.Mask = "000_000_000_-00";
            mkbCPF.Name = "mkbCPF";
            mkbCPF.Size = new Size(100, 23);
            mkbCPF.TabIndex = 3;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(176, 41);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(25, 96);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 4;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(31, 114);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(245, 23);
            txtNomeCompleto.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-Mail";
            // 
            // mtbDddCelular
            // 
            mtbDddCelular.Location = new Point(25, 231);
            mtbDddCelular.Mask = "(99) 00000-0000";
            mtbDddCelular.Name = "mtbDddCelular";
            mtbDddCelular.Size = new Size(100, 23);
            mtbDddCelular.TabIndex = 9;
            // 
            // lblDddCelular
            // 
            lblDddCelular.AutoSize = true;
            lblDddCelular.Location = new Point(25, 214);
            lblDddCelular.Name = "lblDddCelular";
            lblDddCelular.Size = new Size(66, 15);
            lblDddCelular.TabIndex = 8;
            lblDddCelular.Text = "DddCelular";
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(148, 231);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(128, 106);
            gbxTipoTelefone.TabIndex = 10;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(6, 72);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(6, 47);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbPossuiFilhos
            // 
            rdbPossuiFilhos.AutoSize = true;
            rdbPossuiFilhos.Location = new Point(31, 304);
            rdbPossuiFilhos.Name = "rdbPossuiFilhos";
            rdbPossuiFilhos.Size = new Size(96, 19);
            rdbPossuiFilhos.TabIndex = 11;
            rdbPossuiFilhos.TabStop = true;
            rdbPossuiFilhos.Text = "Possui Filhos ";
            rdbPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(80, 391);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(195, 391);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(rdbPossuiFilhos);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(mtbDddCelular);
            Controls.Add(lblDddCelular);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(mkbCPF);
            Controls.Add(lblCPF);
            Controls.Add(mtbCodigo);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            Text = "FormCadastro";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private MaskedTextBox mtbCodigo;
        private MaskedTextBox mkbCPF;
        private Label lblCPF;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mtbDddCelular;
        private Label lblDddCelular;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private RadioButton rdbPossuiFilhos;
        private Button btnVoltar;
        private Button btnCadastrar;
    }
}