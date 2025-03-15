using System.Runtime.InteropServices;

namespace WFAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "admin";
            us.Senha = "admin";
            us.DataCadastro = Convert.ToDateTime("01/01/2000");
            //us.DataCadastro = DateTime.Parse("01/01/2000");
            Usuario.ListaUsuarios.Add(us);

            us = new Usuario();
            us.Codigo = 2;
            us.Login = "user";
            us.Senha = "user";
            us.DataCadastro = Convert.ToDateTime("01/01/2010");
            //us.DataCadastro = DateTime.Parse("01/01/2010");
            Usuario.ListaUsuarios.Add(us);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            {
                foreach (Usuario user in Usuario.ListaUsuarios)
                {
                    if (user.Login == txtLogin.Text)
                    {
                        if (user.Senha == txtSenha.Text)
                        {
                            MessageBox.Show(
                                "Usuario Autenticado com Sucesso!",
                                "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                            return;
                        }
                    }

                }

                MessageBox.Show("Usuario Não Autenticado!",
                                "Erro!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }
    }
}

   

