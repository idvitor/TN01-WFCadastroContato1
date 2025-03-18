namespace WFUsandoListagem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
           
        {

        }
        

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "user";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("10/01/2025 18:30");

            Usuario.ListaUsuarios.Add(us);
        }
    }
}
