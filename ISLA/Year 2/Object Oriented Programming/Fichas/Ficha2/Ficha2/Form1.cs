using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Exercicio 1



        private void ButtonExercicio1_1_Click(object sender, EventArgs e)
        {
            //Criar um objeto do tipo de dados string e inicializalo
            string texto = string.Empty;

            //Criar um objeto do tipo de dados Integer
            int numero = 0;

            //Criar um objeto do tipo de dados DateTime
            DateTime data = new DateTime(2016, 1, 1);

            //Criar um objeto do tipo de dados Equipa
            Equipa equipa = new Equipa();
        }

        private void ButtonExercicio1_2_Click(object sender, EventArgs e)
        {
            //Crie um construtor na classe Equipa que preencha as propriedades nome e data de fundação
            //Crie um objecto utilizando o construtor criado
            Equipa equipa = new Equipa("ABC", new DateTime(1983, 1, 1));
        }

        private void ButtonExercicio1_3_Click(object sender, EventArgs e)
        {
            //Crie um método na classe Equipa que retorne a idade em anos desde a fundação da equipa e exemplifique
            Equipa equipa = new Equipa("DSV", new DateTime(1985, 12, 9));
            int idadeEquipa = 0;

            idadeEquipa = equipa.Idade();

            MessageBox.Show("A idade da equipa é = " + idadeEquipa.ToString());
        }

        private void ButtonExercicio1_4_Click(object sender, EventArgs e)
        {
            //Crie um método na classe equipa que retorne em letra romana o seculo da fundação da equipa e exemplifique
            Equipa equipa = new Equipa("ABC", new DateTime(1830, 2, 2));
            string seculo = String.Empty;

            seculo = equipa.Seculo();

            MessageBox.Show(string.Format("O século da fundação da equipa é o século {0}", seculo));
        }

        private void ButtonExercicio1_5_Click(object sender, EventArgs e)
        {
            //Crie um método na classe equipa que retorne quantos dias faltam para o seu aniversario e exemplifique
            Equipa equipa = new Equipa();
            int dias = 0;

            equipa.NomeEquipa = "ABC";
            equipa.DataFundacao = new DateTime(1920, 11, 21);
            dias = equipa.Aniversario();

            MessageBox.Show(string.Format("Faltam {0} dias para o aniversário", dias.ToString()));
        }

        #endregion

        private void ButtonExercicio2_1_Click(object sender, EventArgs e)
        {
            //criar um método na classe equipa que retorne o nº de carateres da propriedade nome e exemplifique
            Equipa equipa = new Equipa("Futebol Club do Porto", new DateTime(1906, 8, 1));
            int carateres = 0;

            carateres = equipa.NumeroCarateres();

            MessageBox.Show("A Equipa " + equipa.NomeEquipa + " tem " + carateres.ToString() + " CARATERES.");
        }

        private void ButtonExercicio2_2_Click(object sender, EventArgs e)
        {
            //criar um método na classe equipa que retorne o nº de palavras  da propriedade nome e exemplifique
            Equipa equipa = new Equipa("Futebol Club do Porto", new DateTime(1906, 8, 1));
            int palavras = 0;

            palavras = equipa.NumeroPalavras();

            MessageBox.Show("A Equipa " + equipa.NomeEquipa + " tem " + palavras.ToString() + " palavras.");
        }

        private void ButtonExercicio2_3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExercicio3_1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            Aluno alunoX = new Aluno();
            Aluno alunoY;
            alunoY = new Aluno();

            int numeroAluno = 0;
            numeroAluno = 123;

            aluno.NumeroAluno = numeroAluno;

            DateTime dataNascimento;
            dataNascimento = new DateTime(1989, 1, 2);

            aluno.DataNascimento = dataNascimento;

            Aluno alunoW = new Aluno(124, new DateTime(2000, 4, 2));
            Aluno AlunoZ = new Aluno(126, new DateTime(1985, 9, 23));
        }

        private void ButtonExercicio3_2_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(837, new DateTime(1988, 7, 3));

            int idade = 0;
            idade = aluno.Idade();

            this.LabelResultadoIdade.Text = idade.ToString();
        }

        private void ButtonExercicio3_3_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(123, new DateTime(1989, 2, 3));

            string seculo = String.Empty;
            seculo = aluno.Seculo();

            this.LabelResultadoSeculo.Text = seculo;
        }

        private void ButtonExercicio4_1_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro("AA-12-33", "Renault", 1200);

            float taxaImposto = 0f;
            taxaImposto = carro.TaxaImposto();

            this.LabelResultadoTaxa.Text = taxaImposto.ToString();
        }

        private void ButtonExercicio4_2_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro("98-72-DD", "Ford", 1200);

            string descricaoMarca = String.Empty;
            descricaoMarca = carro.DescricaoMarca();

            this.LabelResultadoMarca.Text = descricaoMarca;
        }

        private void ButtonExercicio4_3_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro("BB-AA-33", "Fiat", 1200, true);

            bool pagaImposto = false;
            pagaImposto = carro.PagaImposto();

            this.CheckBoxPagaImposto.Checked = pagaImposto;
        }

        private void ButtonExercicio4_4_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro("BB-AA-33", "Fiat", 1200, true);

            bool pagaImposto = false;
            float taxaImposto = 0F;
            pagaImposto = carro.PagaImposto(ref taxaImposto);

            this.CheckBoxPagaImposto.Checked = pagaImposto;
        }
    }
}
