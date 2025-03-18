namespace WFUsandoListagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            lblCadastroUsuarios = new Label();
            lblLogin1 = new Label();
            lblSenha1 = new Label();
            lblSenha2 = new Label();
            txtLoginNovo = new TextBox();
            txtSenhaNovo = new TextBox();
            txtSenhaConfirmar = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblCadastroUsuarios
            // 
            lblCadastroUsuarios.AutoSize = true;
            lblCadastroUsuarios.Location = new Point(12, 9);
            lblCadastroUsuarios.Name = "lblCadastroUsuarios";
            lblCadastroUsuarios.Size = new Size(155, 15);
            lblCadastroUsuarios.TabIndex = 0;
            lblCadastroUsuarios.Text = "Cadastro de Novos Usuarios";
            // 
            // lblLogin1
            // 
            lblLogin1.AutoSize = true;
            lblLogin1.Location = new Point(12, 64);
            lblLogin1.Name = "lblLogin1";
            lblLogin1.Size = new Size(37, 15);
            lblLogin1.TabIndex = 1;
            lblLogin1.Text = "Login";
            // 
            // lblSenha1
            // 
            lblSenha1.AutoSize = true;
            lblSenha1.Location = new Point(12, 119);
            lblSenha1.Name = "lblSenha1";
            lblSenha1.Size = new Size(39, 15);
            lblSenha1.TabIndex = 2;
            lblSenha1.Text = "Senha";
            // 
            // lblSenha2
            // 
            lblSenha2.AutoSize = true;
            lblSenha2.Location = new Point(12, 167);
            lblSenha2.Name = "lblSenha2";
            lblSenha2.Size = new Size(96, 15);
            lblSenha2.TabIndex = 3;
            lblSenha2.Text = "Confirmar Senha";
            // 
            // txtLoginNovo
            // 
            txtLoginNovo.Location = new Point(67, 56);
            txtLoginNovo.Name = "txtLoginNovo";
            txtLoginNovo.PlaceholderText = "Informe o Login..";
            txtLoginNovo.Size = new Size(100, 23);
            txtLoginNovo.TabIndex = 1;
            // 
            // txtSenhaNovo
            // 
            txtSenhaNovo.Location = new Point(67, 111);
            txtSenhaNovo.Name = "txtSenhaNovo";
            txtSenhaNovo.PasswordChar = '*';
            txtSenhaNovo.PlaceholderText = "Informe a Senha..";
            txtSenhaNovo.Size = new Size(100, 23);
            txtSenhaNovo.TabIndex = 2;
            // 
            // txtSenhaConfirmar
            // 
            txtSenhaConfirmar.Location = new Point(114, 159);
            txtSenhaConfirmar.Name = "txtSenhaConfirmar";
            txtSenhaConfirmar.PasswordChar = '*';
            txtSenhaConfirmar.PlaceholderText = "Confirme a Senha..";
            txtSenhaConfirmar.Size = new Size(119, 23);
            txtSenhaConfirmar.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(67, 206);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(147, 39);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 257);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaConfirmar);
            Controls.Add(txtSenhaNovo);
            Controls.Add(txtLoginNovo);
            Controls.Add(lblSenha2);
            Controls.Add(lblSenha1);
            Controls.Add(lblLogin1);
            Controls.Add(lblCadastroUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroUsuarios;
        private Label lblLogin1;
        private Label lblSenha1;
        private Label lblSenha2;
        private TextBox txtLoginNovo;
        private TextBox txtSenhaNovo;
        private TextBox txtSenhaConfirmar;
        private Button btnCadastrar;
    }
}