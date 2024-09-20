using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009___Projeto_Final
{
    public partial class formInserirVendedor : Form
    {
        public formInserirVendedor()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string sNome = txtNome.Text;
            decimal dComissao;
            if (txtComissao.Text != "" && txtNome.Text != "")
            {
                try
                {
                    dComissao = Convert.ToDecimal(txtComissao.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtComissao.Text = "";
                    return;
                }

                try
                {
                    //Query para inserir o vendedor na base de dados
                    string query = $"INSERT INTO Vendedores (Nome, Comissao) VALUES ('{sNome}', {dComissao.ToString().Replace(",", ".")})";
                    //Query para verificar se o vendedor já existe
                    string queryCheck = $"SELECT * FROM Vendedores WHERE Nome = '{sNome}'";

                    DatabaseManager db = new DatabaseManager();

                    //Verificar se o vendedor já existe
                    if (db.SelectDataTable(queryCheck).Rows.Count > 0)
                    {
                        MessageBox.Show("Vendedor já existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.NonQuery(query);

                    MessageBox.Show("Vendedor inserido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
