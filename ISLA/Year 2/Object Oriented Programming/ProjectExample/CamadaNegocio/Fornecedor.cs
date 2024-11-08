using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Fornecedor
    {
        public int CodigoFornecedor { get; set; }
        public string NomeFornecedor { get; set; }

        public static Fornecedor ObterCodigoFornecedor(int codigoFornecedor)
        {
            DataTable dataTable = CamadaDados.Fornecedor.ObterCodigoFornecedor(codigoFornecedor);

            Fornecedor fornecedor = null;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];

                if (dataRow != null)
                {
                    fornecedor = new Fornecedor();

                    fornecedor.CodigoFornecedor = dataRow.Field<int>("CodigoFornecedor");
                    fornecedor.NomeFornecedor = dataRow.Field<string>("NomeFornecedor");

                }
            }

            return fornecedor;
        }

        public static FornecedorCollection ObterLista()
        {
            //Base de dados dá sempre uma DataTable
            DataTable dataTable = CamadaDados.Fornecedor.ObterLista();

            FornecedorCollection fornecedores = new FornecedorCollection();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.CodigoFornecedor = dataRow.Field<int>("CodigoFornecedor");
                fornecedor.NomeFornecedor = dataRow.Field<string>("NomeFornecedor");

                fornecedores.Add(fornecedor);
            }

            return fornecedores;
        }
    }
}
