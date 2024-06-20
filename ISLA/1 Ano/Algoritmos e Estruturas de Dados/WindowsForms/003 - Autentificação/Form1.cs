using System.Data.SqlClient;

namespace _003___Autentificação
{
    public partial class formAutenticacao : Form
    {
        public formAutenticacao()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //vars de autentificação
            string sLoginName = txtUsername.Text;
            string sPassword = txtPassword.Text;
            if (sLoginName != "" && sPassword != "")
            {
                //verificar se os campos estão preenchidos
                try
                {
                    if (sLoginName != "" && sPassword != "")
                    {
                        //token de acesso à BD
                        SqlConnection conexaoBD = new SqlConnection();
                        //token para acesso ao comando SQL a executar
                        SqlCommand sqlCmd = new SqlCommand();
                        //registo(s) da tabela da BD
                        SqlDataReader recordReader;

                        conexaoBD.ConnectionString = @"Data Source=localhost;Initial Catalog=AutenticacaoAED;Integrated Security=True";

                        //acesso à BD
                        conexaoBD.Open();
                        //atribuição do token da BD ao comando SQL
                        sqlCmd.Connection = conexaoBD;
                        //passar parametros ao comando SQL nomeadamente o sLoginName e sPassword
                        sqlCmd.Parameters.AddWithValue("@sLoginName", sLoginName);
                        sqlCmd.Parameters.AddWithValue("@sPassword", sPassword);
                        //      criar o comando SQL
                        //sqlCmd.CommandText = "SELECT * FROM tblLogin WHERE loginName = '" + sLoginName + "' AND password = '" + sPassword + "'";
                        //sqlCmd.CommandText = "SELECT * FROM tblLogin WHERE loginName = @sLoginName AND password = @sPassword";
                        sqlCmd.CommandText = $"SELECT * FROM tblLogin WHERE loginName = '{sLoginName}' AND password = '{sPassword}'";
                        //executar o comando SQL
                        recordReader = sqlCmd.ExecuteReader();

                        //verificar se o registo existe
                        if (recordReader.HasRows)
                        {
                            MessageBox.Show("Login efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Novo Form
                            Form frmPagInicial = new frmPagInicial();
                            frmPagInicial.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login falhado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Focus();
                        }
                        recordReader.Close();
                        conexaoBD.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ErrorCode + ": " + "Erro na BD: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Preencha os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pwdHide_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pwdHide.Visible = false;
        }

        private void pwdHide_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pwdHide.Visible = true;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Form formRegistar = new frmRegistar();
            formRegistar.ShowDialog();
        }

        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            Form form = new frmRegistar();
            form.ShowDialog();

        }
    }
}
