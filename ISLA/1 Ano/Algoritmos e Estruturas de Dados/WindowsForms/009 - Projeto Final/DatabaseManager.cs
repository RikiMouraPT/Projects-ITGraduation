using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___Projeto_Final
{
    internal class DatabaseManager
    {
        //string conString = "Data Source=localhost;Initial Catalog=GestaoVendas-ProjAED;Integrated Security=True";

        //String de conexão à base de dados
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P1MTD1H\\SQLEXPRESS;Initial Catalog=ProjetoAED;Integrated Security=True");

        public void NonQuery(string query) //Função para inserir/atualizar/apagar dados na base de dados
        {
            try
            { 
                con.Open(); //Abre a conexão
                SqlCommand cmd = new SqlCommand(query, con); //Cria um comando SQL com a query e a conexão de parametro
                cmd.ExecuteNonQuery(); //Executa o comando SQL
            }
            catch (Exception ex) //Caso haja erro, mostra uma mensagem de erro
            {
                //MessageBox.Show($"Error: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Foi tirado o MessageBox para que a mensagem de erro seja tratada no form porque senão dava o erro em duplicado.
                throw new Exception($"Erro: {ex.Message}");
            }
            finally //Por fim fecha a conexão
            {
                con.Close();
            }
        }

        public DataTable SelectDataTable(string query) //Função para selecionar dados na base de 
        {                                              //dados para ser usado em ComboBox por exemplo
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd); // Mete os dados do comando SQL num 'adaptador'
                da.Fill(dt);                                 //Preenche a DataTable com os dados do 'adaptador'
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
