using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009___Projeto_Final
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnFormVendedores_Click(object sender, EventArgs e)
        {
            Form formVendedores = new formVendedores();
            formVendedores.Show();
            this.Hide();
        }

        private void btnFormProdutos_Click(object sender, EventArgs e)
        {
            Form formProdutos = new formProdutos();
            formProdutos.Show();
            this.Hide();
        }

        private void btnFormVendas_Click(object sender, EventArgs e)
        {
            Form formVendas = new formVendas();
            formVendas.Show();
            this.Hide();
        }

        private void btnFormAnalises_Click(object sender, EventArgs e)
        {
            Form formAnalises = new formAnalises();
            formAnalises.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formAnalises = new formAnalises();
            formAnalises.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form formLogin = new formLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
