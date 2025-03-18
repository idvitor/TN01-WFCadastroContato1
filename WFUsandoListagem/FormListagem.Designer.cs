namespace WFUsandoListagem
{
    partial class FormListagem
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
            dgvListagemUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListagemUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvListagemUsuarios
            // 
            dgvListagemUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagemUsuarios.Location = new Point(3, 12);
            dgvListagemUsuarios.Name = "dgvListagemUsuarios";
            dgvListagemUsuarios.Size = new Size(413, 261);
            dgvListagemUsuarios.TabIndex = 0;
            dgvListagemUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 277);
            Controls.Add(dgvListagemUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListagemUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListagemUsuarios;
    }
}