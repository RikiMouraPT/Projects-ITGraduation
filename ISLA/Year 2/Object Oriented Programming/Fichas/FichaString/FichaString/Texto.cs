using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaString
{
    public class Texto
    {
        #region Construtores
        public Texto()
        {
            this.valor = string.Empty;
        }

        public Texto(string parametro)
        {
            this.valor = parametro;
        }

        #endregion

        #region Propriedades

        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        #endregion

        #region Metodos
            
        /// <summary>
        /// Comprimento da string parametro
        /// </summary>
        /// <param name="parametro">Valor do parametro</param>
        /// <returns>retorna o nº de carateres</returns>
        /// <remarks></remarks>
        public int Comprimento(string parametro )
        { 
            return parametro.Length;
        }
            
        /// <summary>
        /// Comprimento da string propriedade Valor
        /// </summary>
        /// <returns></returns>
        public int Comprimento()
        {
            return this.Valor.Length;
        }

        public string TirarEspacos(string h )
        { 
        return h.Trim();
        }

        public string TirarEspacos_V2(string h )
        { 
            string resultado = string.Empty;

            resultado = h.Trim();

            return resultado;
        }

        #endregion
    }
}
