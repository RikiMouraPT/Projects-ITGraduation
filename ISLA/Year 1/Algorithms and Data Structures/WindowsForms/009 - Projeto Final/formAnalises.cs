using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace _009___Projeto_Final
{
    public partial class formAnalises : Form
    {
        public formAnalises()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        /*
            CREATE TABLE Vendedores (
                Codigo INT Identity(1,1) PRIMARY KEY,
                Nome VARCHAR(50),
                Comissao DECIMAL(4,2)
            );

            CREATE TABLE Produtos (
                Codigo VARCHAR(50) PRIMARY KEY,
                Nome VARCHAR(100),
                Categoria VARCHAR(50),
                Preco DECIMAL(10,2)
            );

            CREATE TABLE Vendas (
                Codigo INT IDENTITY(1,1) PRIMARY KEY,
                CodigoVendedor INT REFERENCES Vendedores(Codigo),
                Zona CHAR(1),
                DataVenda DATE,
                Quantidade INT,
                CodigoProduto VARCHAR(50) REFERENCES Produtos(Codigo),
                Valor DECIMAL(10,2)
            );
            CREATE TABLE Login_Info(
                Username VARCHAR(20) PRIMARY KEY,
                Password VARCHAR(20) NOT NULL,
                Administrador BIT DEFAULT 0
            );
        */
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //Query Total Vendas por Vendedor
            string query1 = "SELECT Vendedores.Nome, SUM(Vendas.Valor) AS TotalVendas FROM Vendedores, Vendas WHERE Vendedores.Codigo = Vendas.CodigoVendedor GROUP BY Vendedores.Nome";
            //Query Vendas por Produto
            string query2 = "SELECT Produtos.Nome, SUM(Vendas.Valor) AS TotalVendas FROM Produtos, Vendas WHERE Produtos.Codigo = Vendas.CodigoProduto GROUP BY Produtos.Nome";
            //Query Vendas por Zona
            string query3 = "SELECT Vendas.Zona, SUM(Vendas.Valor) AS TotalVendas FROM Vendas GROUP BY Vendas.Zona";
            //Query Vendas por Mês
            string query4 = "SELECT MONTH(Vendas.DataVenda) AS Mes, SUM(Vendas.Valor) AS TotalVendas FROM Vendas GROUP BY MONTH(Vendas.DataVenda)";

            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dt1 = db.SelectDataTable(query1);
                DataTable dt2 = db.SelectDataTable(query2);
                DataTable dt3 = db.SelectDataTable(query3);
                DataTable dt4 = db.SelectDataTable(query4);

                //Gráfico 1 - Total Vendas por Vendedor
                chart1.ChartAreas.Clear();
                chart1.Series.Clear();

                chart1.ChartAreas.Add("Area");
                chart1.Series.Add("Vendas");
                chart1.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart1.Series["Vendas"].XValueMember = "Nome";
                chart1.Series["Vendas"].YValueMembers = "TotalVendas";
                chart1.Series["Vendas"].IsValueShownAsLabel = true;

                chart1.DataSource = dt1;
                chart1.DataBind();

                //Gráfico 2 - Total Vendas por Produto
                chart2.Series.Clear();
                chart2.ChartAreas.Clear();

                chart2.Series.Add("Vendas");
                chart2.ChartAreas.Add("Area");
                chart2.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart2.Series["Vendas"].XValueMember = "Nome";
                chart2.Series["Vendas"].YValueMembers = "TotalVendas";
                chart2.Series["Vendas"].IsValueShownAsLabel = true;

                chart2.DataSource = dt2;
                chart2.DataBind();

                //Gráfico 3 - Total Vendas por Zona
                chart3.Series.Clear();
                chart3.ChartAreas.Clear();

                chart3.Series.Add("Vendas");
                chart3.ChartAreas.Add("Area");
                chart3.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart3.Series["Vendas"].XValueMember = "Zona";
                chart3.Series["Vendas"].YValueMembers = "TotalVendas";
                chart3.Series["Vendas"].IsValueShownAsLabel = true;

                chart3.DataSource = dt3;
                chart3.DataBind();

                //Gráfico 4 - Total Vendas por Mês
                chart4.Series.Clear();
                chart4.ChartAreas.Clear();

                chart4.Series.Add("Vendas");
                chart4.ChartAreas.Add("Area");
                chart4.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart4.Series["Vendas"].XValueMember = "Mes";
                chart4.Series["Vendas"].YValueMembers = "TotalVendas";
                chart4.Series["Vendas"].IsValueShownAsLabel = true;

                chart4.DataSource = dt4;
                chart4.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            //Query Média de vendas por Vendedor
            string query1 = "SELECT Vendedores.Nome, AVG(Vendas.Valor) AS MediaVendas FROM Vendedores, Vendas WHERE Vendedores.Codigo = Vendas.CodigoVendedor GROUP BY Vendedores.Nome";
            //Query Média de vendas por Produto
            string query2 = "SELECT Produtos.Nome, AVG(Vendas.Valor) AS MediaVendas FROM Produtos, Vendas WHERE Produtos.Codigo = Vendas.CodigoProduto GROUP BY Produtos.Nome";
            //Query Média das comissoes por Vendedor
            string query3 = "SELECT Vendedores.Nome, AVG(Vendas.Valor * (Vendedores.Comissao / 100.0)) AS MediaComissao FROM Vendedores, Vendas WHERE Vendedores.Codigo = Vendas.CodigoVendedor GROUP BY Vendedores.Nome";
            //Query Média de vendas por Zona
            string query4 = "SELECT Vendas.Zona, AVG(Vendas.Valor) AS MediaVendas FROM Vendas GROUP BY Vendas.Zona";

            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dt1 = db.SelectDataTable(query1);
                DataTable dt2 = db.SelectDataTable(query2);
                DataTable dt3 = db.SelectDataTable(query3);
                DataTable dt4 = db.SelectDataTable(query4);

                //Gráfico 1 - Média de vendas por Vendedor
                chart5.ChartAreas.Clear();
                chart5.Series.Clear();

                chart5.ChartAreas.Add("Area");
                chart5.Series.Add("Vendas");
                chart5.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart5.Series["Vendas"].XValueMember = "Nome";
                chart5.Series["Vendas"].YValueMembers = "MediaVendas";
                chart5.Series["Vendas"].IsValueShownAsLabel = true;
                chart5.Series["Vendas"].LabelFormat = "N2";

                chart5.DataSource = dt1;
                chart5.DataBind();

                //Gráfico 2 - Média de vendas por Produto
                chart6.Series.Clear();
                chart6.ChartAreas.Clear();

                chart6.Series.Add("Vendas");
                chart6.ChartAreas.Add("Area");
                chart6.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart6.Series["Vendas"].XValueMember = "Nome";
                chart6.Series["Vendas"].YValueMembers = "MediaVendas";
                chart6.Series["Vendas"].IsValueShownAsLabel = true;
                chart6.Series["Vendas"].LabelFormat = "N2";

                chart6.DataSource = dt2;
                chart6.DataBind();

                //Gráfico 3 - Média das comissoes por Vendedor
                chart7.Series.Clear();
                chart7.ChartAreas.Clear();

                chart7.Series.Add("Vendas");
                chart7.ChartAreas.Add("Area");
                chart7.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart7.Series["Vendas"].XValueMember = "Nome";
                chart7.Series["Vendas"].YValueMembers = "MediaComissao";
                chart7.Series["Vendas"].IsValueShownAsLabel = true;
                chart7.Series["Vendas"].LabelFormat = "N2";

                chart7.DataSource = dt3;
                chart7.DataBind();

                //Gráfico 4 - Média de vendas por Zona
                chart8.Series.Clear();
                chart8.ChartAreas.Clear();

                chart8.Series.Add("Vendas");
                chart8.ChartAreas.Add("Area");
                chart8.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart8.Series["Vendas"].XValueMember = "Zona";
                chart8.Series["Vendas"].YValueMembers = "MediaVendas";
                chart8.Series["Vendas"].IsValueShownAsLabel = true;
                chart8.Series["Vendas"].LabelFormat = "N2";

                chart8.DataSource = dt4;
                chart8.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            //Query Total Vendas por Categoria
            string query1 = "SELECT Produtos.Categoria, SUM(Vendas.Valor) AS TotalVendas FROM Produtos JOIN Vendas ON Produtos.Codigo = Vendas.CodigoProduto GROUP BY Produtos.Categoria";
            //Query Média de Preço por Categoria
            string query2 = "SELECT Produtos.Categoria, AVG(Produtos.Preco) AS MediaPreco FROM Produtos GROUP BY Produtos.Categoria";
            //Query Número de Vendas por Categoria
            string query3 = "SELECT Produtos.Categoria, COUNT(Vendas.Codigo) AS NumeroVendas FROM Produtos JOIN Vendas ON Produtos.Codigo = Vendas.CodigoProduto GROUP BY Produtos.Categoria";
            //Query Média de Vendas por Categoria
            string query4 = "SELECT Produtos.Categoria, AVG(Vendas.Valor) AS MediaVendas FROM Produtos JOIN Vendas ON Produtos.Codigo = Vendas.CodigoProduto GROUP BY Produtos.Categoria";

            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dt1 = db.SelectDataTable(query1);
                DataTable dt2 = db.SelectDataTable(query2);
                DataTable dt3 = db.SelectDataTable(query3);
                DataTable dt4 = db.SelectDataTable(query4);

                //Gráfico 1 - Total Vendas por Categoria
                chart9.ChartAreas.Clear();
                chart9.Series.Clear();

                chart9.ChartAreas.Add("Area");
                chart9.Series.Add("Vendas");
                chart9.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart9.Series["Vendas"].XValueMember = "Categoria";
                chart9.Series["Vendas"].YValueMembers = "TotalVendas";
                chart9.Series["Vendas"].IsValueShownAsLabel = true;

                chart9.DataSource = dt1;
                chart9.DataBind();

                //Gráfico 2 - Média de Preço por Categoria
                chart10.Series.Clear();
                chart10.ChartAreas.Clear();

                chart10.Series.Add("Vendas");
                chart10.ChartAreas.Add("Area");
                chart10.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart10.Series["Vendas"].XValueMember = "Categoria";
                chart10.Series["Vendas"].YValueMembers = "MediaPreco";
                chart10.Series["Vendas"].IsValueShownAsLabel = true;
                chart10.Series["Vendas"].LabelFormat = "N2";

                chart10.DataSource = dt2;
                chart10.DataBind();

                //Gráfico 3 - Número de Vendas por Categoria
                chart11.Series.Clear();
                chart11.ChartAreas.Clear();

                chart11.Series.Add("Vendas");
                chart11.ChartAreas.Add("Area");
                chart11.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart11.Series["Vendas"].XValueMember = "Categoria";
                chart11.Series["Vendas"].YValueMembers = "NumeroVendas";
                chart11.Series["Vendas"].IsValueShownAsLabel = true;

                chart11.DataSource = dt3;
                chart11.DataBind();

                //Gráfico 4 - Média de Vendas por Categoria
                chart12.Series.Clear();
                chart12.ChartAreas.Clear();

                chart12.Series.Add("Vendas");
                chart12.ChartAreas.Add("Area");
                chart12.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart12.Series["Vendas"].XValueMember = "Categoria";
                chart12.Series["Vendas"].YValueMembers = "MediaVendas";
                chart12.Series["Vendas"].IsValueShownAsLabel = true;
                chart12.Series["Vendas"].LabelFormat = "N2";

                chart12.DataSource = dt4;
                chart12.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            //Query Total Vendas por Ano
            string query1 = "SELECT YEAR(Vendas.DataVenda) AS Ano, SUM(Vendas.Valor) AS TotalVendas FROM Vendas GROUP BY YEAR(Vendas.DataVenda)";
            //Query Média de Vendas por Mês
            string query2 = "SELECT MONTH(Vendas.DataVenda) AS Mes, AVG(Vendas.Valor) AS MediaVendas FROM Vendas GROUP BY MONTH(Vendas.DataVenda)";
            //Query Número de Vendas por Ano
            string query3 = "SELECT YEAR(Vendas.DataVenda) AS Ano, COUNT(Vendas.Codigo) AS NumeroVendas FROM Vendas GROUP BY YEAR(Vendas.DataVenda)";
            //Query Média de Vendas por Ano
            string query4 = "SELECT YEAR(Vendas.DataVenda) AS Ano, AVG(Vendas.Valor) AS MediaVendas FROM Vendas GROUP BY YEAR(Vendas.DataVenda)";

            try
            {
                DatabaseManager db = new DatabaseManager();
                DataTable dt1 = db.SelectDataTable(query1);
                DataTable dt2 = db.SelectDataTable(query2);
                DataTable dt3 = db.SelectDataTable(query3);
                DataTable dt4 = db.SelectDataTable(query4);

                //Gráfico 1 - Total Vendas por Ano
                chart13.ChartAreas.Clear();
                chart13.Series.Clear();

                chart13.ChartAreas.Add("Area");
                chart13.Series.Add("Vendas");
                chart13.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart13.Series["Vendas"].XValueMember = "Ano";
                chart13.Series["Vendas"].YValueMembers = "TotalVendas";
                chart13.Series["Vendas"].IsValueShownAsLabel = true;

                chart13.DataSource = dt1;
                chart13.DataBind();

                //Gráfico 2 - Média de Vendas por Mês
                chart14.Series.Clear();
                chart14.ChartAreas.Clear();

                chart14.Series.Add("Vendas");
                chart14.ChartAreas.Add("Area");
                chart14.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart14.Series["Vendas"].XValueMember = "Mes";
                chart14.Series["Vendas"].YValueMembers = "MediaVendas";
                chart14.Series["Vendas"].IsValueShownAsLabel = true;

                chart14.DataSource = dt2;
                chart14.DataBind();

                //Gráfico 3 - Número de Vendas por Ano
                chart15.Series.Clear();
                chart15.ChartAreas.Clear();

                chart15.Series.Add("Vendas");
                chart15.ChartAreas.Add("Area");
                chart15.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart15.Series["Vendas"].XValueMember = "Ano";
                chart15.Series["Vendas"].YValueMembers = "NumeroVendas";
                chart15.Series["Vendas"].IsValueShownAsLabel = true;

                chart15.DataSource = dt3;
                chart15.DataBind();

                //Gráfico 4 - Média de Vendas por Ano
                chart16.Series.Clear();
                chart16.ChartAreas.Clear();

                chart16.Series.Add("Vendas");
                chart16.ChartAreas.Add("Area");
                chart16.Series["Vendas"].ChartType = SeriesChartType.Pie;
                chart16.Series["Vendas"].XValueMember = "Ano";
                chart16.Series["Vendas"].YValueMembers = "MediaVendas";
                chart16.Series["Vendas"].IsValueShownAsLabel = true;

                chart16.DataSource = dt4;
                chart16.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltarTab2_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnVoltarTab3_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnVoltarTab4_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnVoltarTab5_Click(object sender, EventArgs e)
        {
            Form formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
