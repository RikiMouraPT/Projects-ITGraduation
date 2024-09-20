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
    public partial class formVendedores : Form
    {
        public formVendedores()
        {
            InitializeComponent();
        }
        private void formVendedores_Load(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            DataTable dtVendedores = db.SelectDataTable("SELECT * FROM Vendedores"); // Selecionar todos os vendedores e mete-los na dt

            //Adicionar os nomes dos vendedores ao ComboBox
            foreach (DataRow row in dtVendedores.Rows)
            {
                comboBox1.Items.Add(row[1].ToString()); //Adicionar o nome do vendedor, visto que está na segunda coluna
            }

            listVendedores.Items.Clear();
            // Adicionar linhas à ListView com base nas linhas do DataTable
            foreach (DataRow row in dtVendedores.Rows)
            {
                // Criar um ListViewItem para representar cada linha
                ListViewItem item = new ListViewItem(row[0].ToString()); //Primeira coluna do List tem de ser String

                // Adicionar subitens para cada coluna na linha
                for (int i = 1; i < dtVendedores.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString()); //Usar ToString para ter a certeza que é uma string
                }

                // Adicionar o ListViewItem à ListView
                listVendedores.Items.Add(item);
            }

            //Ver se o utilizador é Administrador para saber se tem acesso aos botoes de inserir/alterar/eliminar
            string username = VariaveisGlobais.Username; //Valor do Username que está guardado nas variaveis globais
            string queryAdmin = $"SELECT Administrador FROM Login_Info WHERE Username = '{username}'";
            bool isAdmin = Convert.ToBoolean(db.SelectDataTable(queryAdmin).Rows[0][0]);

            if (isAdmin)
            {
                btnInserir.Enabled = true;
                btnAlterar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new formInserirVendedor();
            form.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form form = new formAlterarVendedor();
            form.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form form = new formEliminarVendedor();
            form.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DatabaseManager db = new DatabaseManager();
            DataTable dtVendedores = db.SelectDataTable("SELECT * FROM Vendedores"); // Selecionar todos os vendedores e mete-los na dt

            comboBox1.Items.Clear();
            //Adicionar os nomes dos vendedores ao ComboBox
            foreach (DataRow row in dtVendedores.Rows)
            {
                comboBox1.Items.Add(row[1].ToString()); //Adicionar o nome do vendedor, visto que está na segunda coluna
            }

            listVendedores.Items.Clear();
            // Adicionar linhas à ListView com base nas linhas do DataTable
            foreach (DataRow row in dtVendedores.Rows)
            {
                // Criar um ListViewItem para representar cada linha
                ListViewItem item = new ListViewItem(row[0].ToString()); //Primeira coluna do List tem de ser String

                // Adicionar subitens para cada coluna na linha
                for (int i = 1; i < dtVendedores.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString()); //Usar ToString para ter a certeza que é uma string
                }

                // Adicionar o ListViewItem à ListView
                listVendedores.Items.Add(item);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e) //Calculo da comissão de vendas
        {
            if (comboBox1.SelectedIndex == -1) //Se não tiver nenhum vendedor selecionado
            {
                MessageBox.Show("Por favor selecione um vendedor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string sVendedor = comboBox1.Text; //Vendedor selecionado no ComboBox

                DatabaseManager db = new DatabaseManager();

                string queryCodigo = $"SELECT Codigo FROM Vendedores WHERE Nome = '{sVendedor}'"; //Query para obter o código do vendedor
                int codigoVendedor = Convert.ToInt32(db.SelectDataTable(queryCodigo).Rows[0][0]); //Pegar no codigo e Converter para int

                string queryComissao = $"SELECT Comissao FROM Vendedores Where Nome = '{sVendedor}'"; //Query para obter a comissão do vendedor
                double comissao = Convert.ToDouble(db.SelectDataTable(queryComissao).Rows[0][0]); //Pegar na comissão e Converter para double

                string queryVendas = $"SELECT * FROM Vendas WHERE CodigoVendedor = ({codigoVendedor})"; //Query para obter as vendas do vendedor
                DataTable dtVendas = db.SelectDataTable(queryVendas);

                double totalComissao = 0;
                foreach (DataRow row in dtVendas.Rows)
                {
                    double valorVenda = Convert.ToDouble(row[6]); //Converter o valor da venda para double
                    totalComissao += valorVenda * comissao / 100; //Calcular a comissão
                }

                txtValor.Text = totalComissao.ToString("C"); //Mostrar o valor da comissão
            }
        }
    }
}
