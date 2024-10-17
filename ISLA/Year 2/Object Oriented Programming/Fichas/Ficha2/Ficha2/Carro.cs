using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    public class Carro
    {

        #region Construtores

        public Carro()
        {
            this.cilindrada = 0;
            this.marca = String.Empty;
            this.matricula = String.Empty;
            this.eletrico = false;
        }

        public Carro(string matricula, string marca, int cilindrada)
            : this()
        {
            this.cilindrada = cilindrada;
            this.marca = marca;
            this.matricula = matricula;
        }

        public Carro(string matricula, string marca, int cilindrada, bool eletrico)
            : this(matricula, marca, cilindrada)
        {
            this.eletrico = eletrico;
        }

        #endregion

        #region Propriedades

        private string matricula;
        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        private string marca;
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        private int cilindrada;
        public int Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        private bool eletrico;
        public bool Eletrico
        {
            get { return this.eletrico; }
            set { this.eletrico = value; }
        }

        #endregion

        #region Métodos

        public float TaxaImposto()
        {
            float taxa = 0F;

            if (this.Cilindrada <= 1000)
            {
                taxa = 0.2F;
            }
            else if (this.Cilindrada <= 2000)
            {
                taxa = 0.25F;
            }
            else if (this.Cilindrada <= 3000)
            {
                taxa = 0.3F;
            }
            else
            {
                taxa = 0.35F;
            }

            return taxa;
        }

        public string DescricaoMarca()
        {
            return this.Marca.ToUpper();
        }

        public bool PagaImposto()
        {
            bool paga = false;

            if (this.Eletrico)
            {
                paga = false;
            }
            else
            {
                paga = true;
            }
            return paga;
        }

        public bool PagaImposto(ref float taxaImposto)
        {
            bool paga = false;
            taxaImposto = 0F;

            if (this.Eletrico)
            {
                paga = false;
            }
            else
            {
                paga = true;
                taxaImposto = this.TaxaImposto();
            }

            return paga;
        }

        #endregion
    }
}
