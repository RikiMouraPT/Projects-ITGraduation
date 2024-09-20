using System;
using System.Collections;
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
    public partial class formEliminarVendedor : Form
    {
        public formEliminarVendedor()
        {
            InitializeComponent();
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

        private void formEliminarVendedor_Load(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sUsername = comboBox1.Text;

                //Query para eliminar o vendedor da base de dados e as respetivas vendas, primeiro sendo necessário eliminar as vendas, por causa da foreign key
                string query = $"DELETE FROM Vendas WHERE CodigoVendedor = (SELECT Codigo FROM Vendedores WHERE Nome = '{sUsername}'); DELETE FROM Vendedores WHERE Nome = '{sUsername}'";

                //Confirmar se quer realemente eliminar as vendas e o vendedor
                DialogResult resposta;
                resposta = MessageBox.Show("Queres mesmo eliminar o vendedor e as respetivas vendas?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.No)
                    return;

                DatabaseManager db = new DatabaseManager();
                db.NonQuery(query);


                MessageBox.Show("Vendedor e respetivas vendas eliminado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
