using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LimparFormulario()
        {
            txtLoginNovo.Clear();
            txtSenhaNovo.Clear();
            txtSenhaConfirmar.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           if(txtSenhaNovo.Text != txtSenhaConfirmar.Text)
            {
                Erro("As Senhas devem ser iguais");
                return;
            }

            Usuario novoUs = new Usuario();
            novoUs.Codigo = Usuario.ListaUsuarios.Count + 1
                novoUs.Login = txtLoginNovo.Text
                novoUs.Senha = txtSenhaNovo.Text
                novoUs.DataCadastro = DateTime.Now

                Usuario.ListaUsuarios.Add(novoUs);

            Close();

            FormListagem = new FormListagem


        }
    }
}
