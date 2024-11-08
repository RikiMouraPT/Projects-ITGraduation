using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Fornecedor
    {
        public static bool Obter(int codigoFornecedor, ref string nomeFornecedor, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            return resultado;
        }
        public static DataTable ObterCodigoFornecedor(int codigoFornecedor)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "FornecedorObter";

                SqlParameter sqlParameter = new SqlParameter("CodigoFornecedor", SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoFornecedor;

                sqlCommand.Parameters.Add(sqlParameter);

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dataTable;
        }

        public static DataTable ObterLista()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ListaFornecedores";

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);
                
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dataTable;

        }
    }
}
