using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    public class Equipa
    {
        #region Construtores

        public Equipa()
        {
            this.nomeEquipa = String.Empty;
            this.dataFundacao = DateTime.Now.Date;
        }

        //Resposta 1.2
        public Equipa(string nomeEquipa, DateTime dataFundacao)
        {
            this.nomeEquipa = nomeEquipa;
            this.dataFundacao = dataFundacao;
        }

        #endregion

        #region Propriedades

        private string nomeEquipa;
        public string NomeEquipa
        {
            get { return this.nomeEquipa; }
            set { this.nomeEquipa = value; }
        }

        private DateTime dataFundacao;
        public DateTime DataFundacao
        {
            get { return this.dataFundacao; }
            set { this.dataFundacao = value; }
        }

        #endregion

        #region Métodos

        //Exercicio 1.3
        public int Idade()
        {
            int resultado = 0;

            resultado = DateTime.Now.Date.Year - this.DataFundacao.Year + 1;

            return resultado;
        }

        //Exercicio 1.4
        public string Seculo()
        {
            string resultado = String.Empty;
            int ano = 0;

            ano = this.DataFundacao.Year;
            if (ano < 1900)
            {
                resultado = "XIX";
            }
            else if (ano < 2000)
            {
                resultado = "XX"; }
            else
            {
                resultado = "XXI";
            }
        
            return resultado;
        }

        //Exercicio 1.5
        public int Aniversario()
        {
            int resultado = 0;

            //obter a data de proximo Aniversário
            DateTime aniversario;
            aniversario = this.ObterDataProximoAniversario();

            //obter a diferença em dias entre a data de hoje e a data do proximo aniversário
            resultado = DateTime.Now.Date.Subtract(aniversario).Days + 1;

            return resultado;
        }

        //Exercicio 1.5
        public DateTime ObterDataProximoAniversario()
        {
            DateTime aniversario;
            int ano = 0;
            int mes = 0;
            int dia = 0;

            dia = this.DataFundacao.Day;
            mes = this.DataFundacao.Month;
            ano = DateTime.Now.Year;

            aniversario = new DateTime(ano, mes, dia);
            if (aniversario < DateTime.Now.Date)
            {
                aniversario = aniversario.AddYears(1);
            }

            return aniversario;
        }

        //Exercicio 2.1
        public int NumeroCarateres()
        {
            int resultado = 0;

            resultado = this.NomeEquipa.Length;

            return resultado;
        }

        // Exercicio 2.2
        public int NumeroPalavras()
        { 
            int resultado = 0;
            string[] palavras;

            palavras = this.NomeEquipa.Split(' ');

            resultado = palavras.Length;

            return resultado;
        }

        #endregion

    }
}
