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
    public partial class formAlterarVendedor : Form
    {
        public formAlterarVendedor()
        {
            InitializeComponent();
        }
        private void formAlterarVendedor_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dtVendedores = db.SelectDataTable("SELECT * FROM Vendedores");

                comboBox1.Items.Clear();

                foreach (DataRow row in dtVendedores.Rows)
                {
                    comboBox1.Items.Add(row[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtComissao.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string sComissao = txtComissao.Text;
                if (sComissao == "")
                {
                    MessageBox.Show("Introduza um valor para a comissão!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseManager db = new DatabaseManager();
                DataTable dtVendedores = db.SelectDataTable("SELECT * FROM Vendedores");

                int idVendedor = 0;
                foreach (DataRow row in dtVendedores.Rows)
                {
                    if (comboBox1.SelectedItem.ToString() == row[1].ToString()) //Se o item selecionado no ComboBox for igual ao nome do vendedor
                    {
                        idVendedor = Convert.ToInt32(row[0]); //Guarda o ID do vendedor
                        break;
                    }
                }

                string query = $"UPDATE Vendedores SET Comissao = {sComissao.ToString().Replace(",", ".")} WHERE codigo = {idVendedor}";
                db.NonQuery(query);

                MessageBox.Show("Comissão alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComissao.Text = "";
            }
        }
    }
}
