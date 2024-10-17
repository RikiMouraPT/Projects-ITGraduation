using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Sair

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            //[Fechar o Form]
            this.Dispose();
            //[Fechar o Programa/Aplicação] 
            Application.Exit();
        }

        #endregion

        #region Exercicio 1
        //1.	Escreva uma função que dado um Nome (String), retorne o nº de caracteres
        private void btnFichaInicial1_N1_Click(object sender, EventArgs e)
        {
            //Declaração de uma variável do tipo string e inicialização a ""
            string s = String.Empty;
            int n = 0;

            s = TextBoxArgumento1.Text;
            n = this.NumeroCaracteres(s);
            this.TextBoxResultado1.Text = n.ToString();
        }

        private int NumeroCaracteres(string valor)
        {
            return valor.Length;
        }
        #endregion

        #region Exercicio 2
        //2.	Escreva uma função que dado um Nome (String), retorne o nº de palavras
        private void btnFichaInicial1_N2_Click(object sender, EventArgs e)
        {
            //Declaração de uma variável do tipo string e inicialização a ""
            string s = string.Empty;
            int n = 0;

            s = this.TextBoxArgumento2.Text;
            n = this.NumeroPavavras(s);
            this.TextBoxResultado2.Text = n.ToString();
        }

        private int NumeroPavavras(string valor)
        {
            //Definição de um vector de String's
            string[] palavras;
            //Dividir a string "valor" por espaços
            palavras = valor.Trim().Split(' ');

            //retornar o nº de posições do vector ou seja o n de palavras
            return palavras.Length;
        }
        #endregion

        #region Exercicio 3
        //o nº de vezes que aparece o carácter ‘N’
        private void btnFichaInicial1_N3_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            string c = string.Empty;
            int n = 0;

            s = this.TextBoxArgumento3.Text;
            c = this.TextBoxArgumento3_2.Text;
            n = this.NumeroVezesCaracteres(s, c);
            n = this.NumeroVezesCaracteres2(s, c);
            this.TextBoxResultado3.Text = n.ToString();
        }

        private int NumeroVezesCaracteres(string valor, string caracter)
        {
            int caracteres = 0;
            int contador = 0;

            if (!string.IsNullOrEmpty(caracter))
            {
                caracteres = valor.Length;

                for (int n = 0; n <= caracteres - 1; n++)
                {
                    if (valor[n].ToString() == caracter)
                    {
                        contador += 1;
                    }

                }
            }
            return contador;
        }

        private int NumeroVezesCaracteres2(string valor, string caracter)
        {
            string temp = string.Empty;
            int contador = 0;

            if (!string.IsNullOrEmpty(caracter))
            {
                temp = valor.Replace(caracter, "");
                contador = valor.Length - temp.Length;
                contador = this.NumeroCaracteres(valor) - this.NumeroCaracteres(temp);
            }
            return contador;
        }

        #endregion

        #region Exercicio 4
        //4.	Escreva um programa que dado um Nome Ex: ‘antónio silva fernandes’ retorne ‘António Silva Fernandes’
        private void btnFichaInicial1_N4_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            string n = string.Empty;

            s = this.TextBoxArgumento4.Text;
            n = this.Exercicio4(s);
            this.TextBoxResultado4.Text = n.ToString();
        }

        private string Exercicio4(string valor)
        {
            //Definição de um vector de String's
            string[] palavras;
            string resultado = string.Empty;

            valor = valor.ToLower();
            //Dividir a string "valor" por espaços
            palavras = valor.Split(' ');

            for (int n = 0; n <= palavras.Length - 1; n++)
            {
                resultado += (palavras[n][0]).ToString().ToUpper() +
                    palavras[n].Substring(1) + " ";

            }
            resultado = resultado.Trim();
            //retornar o nº de posições do vector ou seja o n de palavras
            return resultado;
        }

        private string Exercicio4_v2(string valor)
        {
            string resultado = string.Empty;
            int caracteres = 0;
            bool seguinte = false;

            caracteres = this.NumeroCaracteres(valor);
            valor = valor.ToLower();

            for (int n = 0; n <= caracteres - 1; n++)
            {
                if (n == 0)
                {
                    resultado = valor[0].ToString().ToUpper();
                }
                else if (valor[n].ToString() == " ")
                {
                    seguinte = true;
                    resultado += valor[n].ToString();
                }
                else
                {
                    if (seguinte == true)
                    {
                        resultado += valor[n].ToString().ToUpper();
                        seguinte = false;
                    }
                    else
                    {
                        resultado += valor[n].ToString();
                    }
                }
            }

            return resultado;

        }
        #endregion

        #region Exercicio 5
        //5.	Escreva uma função que dado um Nome Ex: ‘António Silva Fernandes’ retorne ‘António Fernandes’?
        private void btnFichaInicial1_N5_Click(object sender, EventArgs e)
        {
            string nome = string.Empty;
            string resultado = string.Empty;

            nome = this.TextBoxArgumento5.Text;
            resultado = this.Exercicio5(nome);
            this.TextBoxResultado5.Text = resultado;
        }

        private string Exercicio5(string valor)
        {
            string resultado = string.Empty;
            string[] palavras;

            valor = valor.Trim();

            palavras = valor.Split(' ');
            if (palavras.Length >= 2)
            {
                resultado = palavras[0];
                resultado += " ";
                resultado += palavras[palavras.Length - 1];
            }
            else
            {
                resultado = valor;
            }
            return resultado;
        }

        #endregion

        #region Exercicio 6
        //6.	Escreva uma função que dado um Nome Ex: ‘António Silva Fernandes’ retorne ‘Fernandes, António S.’?
        private void btnFichaInicial1_N6_Click(object sender, EventArgs e)
        {
            string nome = string.Empty;
            string resultado = string.Empty;

            nome = this.TextBoxArgumento6.Text;
            resultado = this.Exercicio6(nome);
            this.TextBoxResultado6.Text = resultado;
        }

        private string Exercicio6(string valor)
        {
            string resultado = string.Empty;
            string[] palavras;

            valor = valor.Trim();

            palavras = valor.Split(' ');

            //[Adicionar a última palavra]
            resultado = palavras[palavras.Length - 1];
            resultado += ", ";
            //[Adicionar a primeira palavra]
            resultado += palavras[0];
            resultado += " ";

            //[percorrer as palavras da 2ª palavra até à antepenultima ]
            for (int n = 1; n <= palavras.Length - 2; n++)
            {
                if (string.IsNullOrEmpty(palavras[n]))
                {
                    resultado += palavras[n][0].ToString();
                    resultado += ".";
                }
            }

            return resultado;
        }

        #endregion

        #region Exercicio 7
        // 7.	Escreva uma função que dado um Nome Ex: ‘António Silva Fernandes’ retorne ‘A. S. F.’?
        private void btnFichaInicial1_N7_Click(object sender, EventArgs e)
        {
            string nome = string.Empty;
            string resultado = string.Empty;

            nome = this.TextBoxArgumento7.Text;
            resultado = this.Exercicio7(nome);
            this.TextBoxResultado7.Text = resultado;
        }

        private string Exercicio7(string valor)
        {
            string resultado = string.Empty;
            string[] palavras;

            valor = valor.Trim();

            palavras = valor.Split(' ');

            //[Da 1ª palavra à ultima]
            for (int n = 0; n <= palavras.Length - 1; n++)
            {
                if (palavras[n] != String.Empty)
                {
                    resultado += palavras[n][0].ToString().ToUpper();
                    resultado += ". ";
                }
            }

            return resultado;
        }

        #endregion

        #region Exercicio 8
        //8.	Escrever uma função que inverta uma string?
        private void btnFichaInicial1_N8_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string resultado = string.Empty;

            texto = this.TextBoxArgumento8.Text;
            resultado = this.Exercicio8(texto);
            this.TextBoxResultado8.Text = resultado;
        }

        private string Exercicio8(string valor)
        {
            string resultado = string.Empty;
            //[percorrer os caracteres do último para o primeiro]

            for (int n = valor.Length - 1; n >= 0; n--)
            {
                resultado += valor[n].ToString();
            }

            return resultado;
        }

        #endregion

        #region Exercicio 9
        //'9.	Escrever uma função que Verifique se existe uma String Dentro doutra String?
        private void btnFichaInicial1_N9_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string procura = string.Empty;
            bool resultado = false;

            texto = this.TextBoxArgumento9.Text;
            procura = this.TextBoxArgumento9_2.Text;
            resultado = this.Exercicio9(texto, procura);
            if (resultado)
            {
                this.TextBoxResultado9.Text = "Existe";
            }
            else
            {
                this.TextBoxResultado9.Text = "Não Existe";
            }
        }

        private bool Exercicio9(string texto, string textoaprocurar)
        {
            bool resultado = false;
            //[Verifica se o conteúdo da variavel <textoaprocurar> existe no conteúdo da variavel <texto>]
            resultado = texto.Contains(textoaprocurar);
            return resultado;
        }
        #endregion

        #region Exercicio 10
        //10.	Escrever uma função que conte quantas vezes aparece uma palavra num texto?
        private void btnFichaInicial1_N10_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string procura = string.Empty;
            int resultado = 0;

            texto = this.TextBoxArgumento10.Text;
            procura = this.TextBoxArgumento10_2.Text;
            resultado = this.Exercicio10(texto, procura);
            this.TextBoxResultado10.Text = resultado.ToString();
        }

        private int Exercicio10(string texto, string palavraAContar)
        {
            int resultado = 0;
            string[] palavras;

            palavras = texto.Split(' ');

            for (int n = 0; n <= palavras.Length - 1; n++)
            {
                if (palavras[n] == palavraAContar)
                {
                    resultado += 1;
                }
            }
            return resultado;
        }

        #endregion

        #region Exercicio 11
        //11.	Escrever uma função que conte quantas vogais e consoantes existem numa frase?
        private void btnFichaInicial1_N11_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            int vogais = 0;
            int consoantes = 0;

            texto = this.TextBoxArgumento11.Text;
            this.Exercicio11(texto, out vogais, out consoantes);
            this.TextBoxResultado11.Text = vogais.ToString();
            this.TextBoxResultado11_2.Text = consoantes.ToString();
        }

        private void Exercicio11(string texto, out int vogais, out int consoantes)
        {
            string s = string.Empty;
            vogais = 0;
            consoantes = 0;
            //[percorrer os caracteres do primeiro até ao último]

            for (int n = 0; n <= texto.Length - 1; n++)
            {
                s = texto[n].ToString();
                s = s.ToUpper();
                if (s == "A" || s == "E" || s == "I" || s == "O" || s == "U")
                {
                    vogais += 1;
                }
                else if (s != " ")
                {
                    consoantes += 1;
                }
            }
        }

        #endregion

        #region Exercicio 12
        //12.	Escrever uma função que retire dum texto sempre que aparecer nesse texto uma palavra predefinida?
        private void btnFichaInicial1_N12_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string retirar = string.Empty;
            string resultado = string.Empty;

            texto = this.TextBoxArgumento12.Text;
            retirar = this.TextBoxArgumento12_2.Text;
            resultado = this.Exercicio12(texto, retirar);
            this.TextBoxResultado12.Text = resultado;
        }

        private string Exercicio12(string texto, string palavraARetirar)
        {
            string resultado = string.Empty;

            resultado = texto.Replace(palavraARetirar, "");

            return resultado;
        }

        #endregion

        #region Exercicio 13
        //13.	Escrever uma função que retorne a letra do meio ou as letras do meio caso o texto tenha nº de caracteres par?
        private void btnFichaInicial1_N13_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string resultado = string.Empty;

            texto = this.TextBoxArgumento13.Text;
            resultado = this.Exercicio13(texto);
            this.TextBoxResultado13.Text = resultado;
        }

        private string Exercicio13(string texto)
        {
            string resultado = string.Empty;

            if (texto != String.Empty)
            {
                //[Se o nº de caracteres do <texto> for par]
                if (texto.Length % 2 == 0)
                {
                    resultado = texto.Substring((int)(texto.Length / 2) - 1, 2);
                }
                else
                {
                    resultado = texto.Substring((int)(texto.Length / 2), 1);
                }
            }
            return resultado;
        }
        #endregion

        #region Exercicio 14
        //14.	Escrever uma função que retorne a maior palavra dum texto?
        private void btnFichaInicial1_N14_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string resultado = string.Empty;

            texto = TextBoxArgumento14.Text;
            resultado = Exercicio14(texto);
            this.TextBoxResultado14.Text = resultado;
        }

        private string Exercicio14(string texto)
        {
            string resultado = string.Empty;
            string[] palavras;
            int max = 0;

            palavras = texto.Split(' ');

            for (int n = 0; n <= palavras.Length - 1; n++)
            {
                if (palavras[n].Length > max)
                {
                    max = palavras[n].Length;
                    resultado = palavras[n];
                }
            }
            return resultado;
        }
        #endregion

        #region Exercicio 15
        //15.	Escrever uma função que retorne a menor palavra dum texto?
        private void btnFichaInicial1_N15_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            string resultado = string.Empty;

            texto = this.TextBoxArgumento15.Text;
            resultado = this.Exercicio15(texto);
            this.TextBoxResultado15.Text = resultado;
        }

        private string Exercicio15(string texto)
        {
            string resultado = string.Empty;
            string[] palavras;
            int min = texto.Length;

            palavras = texto.Split(' ');

            for (int n = 0; n <= palavras.Length - 1; n++)
            {
                if (palavras[n].Length < min)
                {
                    min = palavras[n].Length;
                    resultado = palavras[n];
                }
            }
            return resultado;
        }
        #endregion

        #region Exercicio 16
        //16.	Escrever uma função que retorne a média de caracteres das palavras dum texto?
        private void btnFichaInicial1_N16_Click(object sender, EventArgs e)
        {
            string texto = string.Empty;
            float resultado = 0F;

            texto = this.TextBoxArgumento16.Text;
            resultado = this.Exercicio16(texto);
            this.TextBoxResultado16.Text = resultado.ToString();
        }

        private float Exercicio16(string texto)
        {
            float resultado = 0F;
            string[] palavras;
            int total = 0;

            palavras = texto.Split(' ');
            if (palavras.Length > 0)
            {
                for (int n = 0; n <= palavras.Length - 1; n++)
                {
                    total += palavras[n].Length;
                }
                resultado = total / palavras.Length;
            }
            return resultado;
        }
        #endregion

        private void ButtonTeste_Click(object sender, EventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("exemplo messagebox", "Titulo",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

            if (r == DialogResult.Cancel)
            {
                MessageBox.Show("CANCEL");
            }
            else if (r == DialogResult.Yes)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void ButtonAula2011_Click(object sender, EventArgs e)
        {
            string a = "   123 abc  ";
            string c = "123 ";
            string b = "";
            int d = 0;

            Texto t = new Texto(a);
            Texto t2 = new Texto("sd");
            Texto t3 = new Texto();

            d = t3.Comprimento();
            MessageBox.Show("[" + d.ToString() + "]");

            d = t2.Comprimento();
            MessageBox.Show("[" + d.ToString() + "]");

            d = t.Comprimento();
            MessageBox.Show("[" + d.ToString() + "]");

            d = t.Comprimento(a);
            MessageBox.Show("[" + d.ToString() + "]");

            b = t.Comprimento(a).ToString();
            MessageBox.Show("[" + b + "]");

            b = t.TirarEspacos(a);
            MessageBox.Show("[" + b + "]");

            b = t.TirarEspacos(c);
            MessageBox.Show("[" + b + "]");

            t = null;
        }
    }
}
