using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003___Autentificação
{
    public partial class frmRegistar : Form
    {
        public frmRegistar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            //vars com os dados do registo
            string sLoginName = txtUsername.Text;
            string sPassword = txtPassword.Text;
            string sRetypePassword = txtRetypePassword.Text;

            //verificar se os campos estão preenchidos
            if (sLoginName != "" && sPassword != "" && sRetypePassword != "")
            {
                //verificar se as passwords são iguais
                if (sPassword == sRetypePassword)
                {
                    try
                    {
                        //token de acesso à BD
                        SqlConnection conexaoBD = new SqlConnection();
                        //token para acesso ao comando SQL a executar
                        SqlCommand sqlCmd = new SqlCommand();

                        conexaoBD.ConnectionString = @"Data Source=localhost;Initial Catalog=AutenticacaoAED;Integrated Security=True";

                        //acesso à BD
                        conexaoBD.Open();
                        //atribuição do token da BD ao comando SQL
                        sqlCmd.Connection = conexaoBD;
                        //criar o comando SQL
                        sqlCmd.CommandText = $"INSERT INTO tblLogin (loginName, password) VALUES ('{sLoginName}', '{sPassword}')";
                        //executar o comando SQL
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Registo efetuado com sucesso!", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexaoBD.Close();
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não são iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
