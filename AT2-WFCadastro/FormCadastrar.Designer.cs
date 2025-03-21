namespace AT2_WFCadastro
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            lblCodigo = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            dtpDataCadastro = new DateTimePicker();
            btnCadastrar = new Button();
            gpbStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            mkbCodigo = new MaskedTextBox();
            lblDataCadastro = new Label();
            gpbStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(41, 212);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(273, 117);
            txtDescricao.TabIndex = 8;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(41, 194);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 10;
            lblDescricao.Text = "Descrição";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(200, 62);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(114, 23);
            dtpDataCadastro.TabIndex = 11;
            dtpDataCadastro.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(200, 400);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 38);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // gpbStatus
            // 
            gpbStatus.Controls.Add(rdbInativo);
            gpbStatus.Controls.Add(rdbAtivo);
            gpbStatus.Location = new Point(42, 335);
            gpbStatus.Name = "gpbStatus";
            gpbStatus.Size = new Size(273, 59);
            gpbStatus.TabIndex = 13;
            gpbStatus.TabStop = false;
            gpbStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(159, 22);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(12, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(42, 153);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(272, 23);
            txtNomeProduto.TabIndex = 14;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(42, 126);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 15;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // mkbCodigo
            // 
            mkbCodigo.Location = new Point(42, 65);
            mkbCodigo.Mask = "0000";
            mkbCodigo.Name = "mkbCodigo";
            mkbCodigo.Size = new Size(100, 23);
            mkbCodigo.TabIndex = 16;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(201, 35);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(97, 15);
            lblDataCadastro.TabIndex = 17;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(357, 450);
            Controls.Add(lblDataCadastro);
            Controls.Add(mkbCodigo);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(gpbStatus);
            Controls.Add(btnCadastrar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            Text = "FormCdastrar";
           
            gpbStatus.ResumeLayout(false);
            gpbStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label label2;
        private TextBox textBox1;
        private Label lblTipos;
        private ComboBox comboBox1;
        private TextBox txtDescricao;
        private Label label4;
        private Label lblDescricao;
        private DateTimePicker dtpDataCadastro;
        private Button btnCadastrar;
        private GroupBox gpbStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private MaskedTextBox mkbCodigo;
        private Label lblDataCadastro;
    }
}