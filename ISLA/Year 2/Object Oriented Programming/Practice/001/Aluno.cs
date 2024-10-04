using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice001
{
    internal class Aluno
    {
        #region Construtores

        public Aluno()
        {
            this.codigo = 0;
            this.nome = string.Empty;
            this.telefone = string.Empty;
        }

        public Aluno(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public Aluno(int codigo, string nome, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.telefone = telefone;
        }

        #endregion

        #region Propiedades

        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        #endregion

        #region Metodos

        public Aluno Copy()
        {
            Aluno aluno = new Aluno();

            return aluno;
        }

        internal Aluno Copy2()
        {
            Aluno aluno = new Aluno();

            aluno.Codigo = codigo;
            aluno.Nome = nome;
            
            
            return aluno;
        }
        #endregion

        
    }
}