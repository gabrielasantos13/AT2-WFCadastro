namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            btnAcessar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(27, 284);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 8;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(27, 227);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Insira sua senha";
            txtSenha.Size = new Size(158, 23);
            txtSenha.TabIndex = 7;
            txtSenha.Tag = "";
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(27, 177);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Insira seu login";
            txtLogin.Size = new Size(158, 23);
            txtLogin.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private TextBox txtSenha;
        private TextBox txtLogin;
    }
}