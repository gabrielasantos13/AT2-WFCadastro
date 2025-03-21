namespace AT2_WFCadastroPessoa
{
    partial class FormMenuu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer componentls = null;

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
        private void InitializeComponençt()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuu));
            picImagem = new PictureBox();
            menuMain = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(800, 426);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 3;
            picImagem.TabStop = false;
            // 
            // menuMain
            // 
            menuMain.BackColor = SystemColors.GradientActiveCaption;
            menuMain.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, listarToolStripMenuItem, sairToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 24);
            menuMain.TabIndex = 2;
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
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FormMenuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picImagem);
            Controls.Add(menuMain);
            Name = "FormMenuu";
            Text = "FormMenuu";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagem;
        private MenuStrip menuMain;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}