using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    public class Aluno
    {
        #region Construtores

        public Aluno()
        {
            this.numeroAluno = 0;
            this.dataNascimento = DateTime.Now.Date;
        }

        public Aluno(int numeroAluno, DateTime dataNascimento)
        {
            this.numeroAluno = numeroAluno;
            this.dataNascimento = dataNascimento;
        }

        #endregion

        #region Propriedades

        private int numeroAluno;
        public int NumeroAluno
        {
            get { return numeroAluno; }
            set { numeroAluno = value; }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        #endregion

        #region Métodos

        public int Idade()
        {
            int idade = 0;

            idade = DateTime.Now.Date.Year - this.DataNascimento.Year + 1;

            return idade;
        }

        public string Seculo()
        {
            string seculo = "XX";

            if (this.DataNascimento.Year >= 2000)
            {
                seculo = "XXI";
            }

            return seculo;
        }

        #endregion

    }
}
