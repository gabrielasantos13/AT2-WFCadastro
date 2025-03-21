namespace AT2_WFCadastro
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuMain = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            picImagem = new PictureBox();
            menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = SystemColors.GradientActiveCaption;
            menuMain.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, listarToolStripMenuItem, sairToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(463, 24);
            menuMain.TabIndex = 0;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 20);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(463, 309);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 333);
            Controls.Add(picImagem);
            Controls.Add(menuMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuMain;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox picImagem;
    }
}