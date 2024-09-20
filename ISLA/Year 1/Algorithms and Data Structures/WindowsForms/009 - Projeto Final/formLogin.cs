using System.Data;

namespace _009___Projeto_Final
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }
        private void pwdHide_MouseDown(object sender, MouseEventArgs e)
        {
            pwdView.Visible = true;
            pwdHide.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }// Evento para mostrar a password
        private void pwdHide_MouseUp(object sender, MouseEventArgs e)
        {
            pwdView.Visible = false;
            pwdHide.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }  // Evento para esconder a password

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Criar as variaveis para o login
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;

            try //Tentar fazer o login
            {
                string query = $"SELECT * FROM Login_Info WHERE Username = '{sUsername}' AND Password = '{sPassword}'";

                DatabaseManager db = new DatabaseManager(); //Criar uma instancia da classe DatabaseManager
                DataTable dt = db.SelectDataTable(query);   //Criar uma DataTable com os dados da query

                if (dt.Rows.Count > 0)  //Se a DataTable tiver mais de 0 linhas, então o login foi efetuado com sucesso
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VariaveisGlobais.Username = sUsername; //Guardar o username na variavel global
                    formMenu form = new formMenu();
                    form.Show();
                    this.Hide();
                }
                else //Se não, então o login falhou
                {
                    MessageBox.Show("Login falhado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            formCriarConta form = new formCriarConta();
            form.ShowDialog();
        }
    }
}
