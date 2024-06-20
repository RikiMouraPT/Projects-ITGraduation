using _009___Projeto_Final;
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

namespace _009___Projeto_Final
{
    public partial class formCriarConta : Form
    {
        public formCriarConta()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void pwdHide_MouseDown(object sender, MouseEventArgs e)
        {
            pwdView.Visible = true;
            pwdHide.Visible = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pwdHide_MouseUp(object sender, MouseEventArgs e)
        {
            pwdView.Visible = false;
            pwdHide.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            string sLoginName = txtUsername.Text;
            string sPassword = txtPassword.Text;
            bool bAdmin = checkBox1.Checked;

            try
            {
                if (sLoginName != "" && sPassword != "")
                {
                    //Query para inserir o novo utilizador na base de dados
                    string query = $"INSERT INTO Login_Info (Username, Password, Administrador) VALUES ('{sLoginName}', '{sPassword}', '{bAdmin}')";
                    //Query para verificar se o utilizador já existe
                    string queryCheck = $"SELECT * FROM Login_Info WHERE Username = '{sLoginName}'";

                    DatabaseManager db = new DatabaseManager();

                    if (db.SelectDataTable(queryCheck).Rows.Count > 0)
                    {
                        MessageBox.Show("Utilizador já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.NonQuery(query);

                    MessageBox.Show("Registo efetuado com sucesso!", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }
    }
}