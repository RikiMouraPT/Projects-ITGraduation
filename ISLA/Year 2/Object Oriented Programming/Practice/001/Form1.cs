using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice001.Venda;

namespace Practice001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            string x = string.Empty;


            Aluno aluno = new Aluno();
            Aluno aluno2 = new Aluno();

            aluno.Codigo = 3;
            aluno.Nome = "Ricardo";
            aluno.Telefone = "0001";

            aluno2.Codigo = aluno.Codigo + 1;

            aluno2 = aluno.Copy2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            string x = string.Empty;
            DateTime data = new DateTime(2024, 1, 10);
            DateTime hoje = DateTime.Today;

            Produto p1 = new Produto();
            Produto p2 = new Produto(1, "Produto 1");
            Produto p3 = new Produto(2, "Produto 2", data, hoje);


            //PROGRAMAR ASSIM
            long id = 2;
            string nome = "XPTO";
            DateTime dataCompra = new DateTime(2020, 1, 1);
            DateTime dataVenda = new DateTime(2020, 1, 2);
            
            Produto p4 = new Produto(id, nome, dataCompra, dataVenda);
            //------------

            this.listBox1.Items.Add(p1.ID + " - " + p1.Nome);   
        }
    }
}