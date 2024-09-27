using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001
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
    }
}