using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice001.Venda
{
    public class Produto
    {
        #region Construtores
        public Produto()
        {
            this.id = 0;
            this.nome = string.Empty;
            this.dataCompra = new DateTime(2000, 1, 1);
            this.dataVenda = new DateTime(999, 9, 9);
        }
        public Produto (long id, string nome)
            : this()
        {
            this.id = id;
            this.nome = nome;
        }
        public Produto (long id, string nome, DateTime dataCompra, DateTime dataVenda)
            : this(id, nome)
        {
            this.dataCompra = dataCompra;
            this.dataVenda = dataVenda;
        }
        #endregion

        #region Propriedades
        private long id;
        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private DateTime dataCompra;
        public DateTime DataCompra
        {
            get { return dataCompra; }
            set { dataCompra = value; }
        }

        private DateTime dataVenda;
        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        #endregion
    }
}
