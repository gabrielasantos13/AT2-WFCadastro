﻿namespace AT2_WFCadastroPessoa
{
    partial class FormLista
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
            dgvListar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListar).BeginInit();
            SuspendLayout();
            // 
            // dgvListar
            // 
            dgvListar.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListar.Dock = DockStyle.Fill;
            dgvListar.Location = new Point(0, 0);
            dgvListar.Name = "dgvListar";
            dgvListar.Size = new Size(800, 450);
            dgvListar.TabIndex = 1;
            dgvListar.CellContentClick += dgvListar_CellContentClick;
            // 
            // FormLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLista";
            Text = "FormLista";
            ((System.ComponentModel.ISupportInitialize)dgvListar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListar;
    }
}