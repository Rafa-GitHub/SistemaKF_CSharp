namespace SistemaKF
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = $"So testando\n{DateTime.Now:D}\n{DateTime.Now:T}";
            Telas telaInicial = new Telas();
            Visible = false;
            telaInicial.ShowDialog();
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuario.login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso NEGADO.");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
