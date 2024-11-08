using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void listFornecedoresButton_Click(object sender, EventArgs e)
        {
            //Obter a lista
            // lista = obterListaFornecedores();
            FornecedorCollection fornecedores = new FornecedorCollection();
            //Static porque não precisamos de instanciar a classe para nada
            fornecedores = Fornecedor.ObterLista();

            //Para cada elemento da lista
            //  Inserir na lista
            //  Objecto.propriedade = elemento
            if (fornecedores != null)
            {
                foreach (Fornecedor fornecedor in fornecedores)
                {
                    this.fornecedoresListBox.Items.Add(fornecedor.NomeFornecedor);
                }
            }
        }

        private void codigoFornecedorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int codigoFornecedor = 0;
                string codigoFornecedorString = this.codigoFornecedorTextBox.Text;

                if (int.TryParse(codigoFornecedorString, out codigoFornecedor))
                {
                    Fornecedor fornecedor = CamadaNegocio.Fornecedor.ObterCodigoFornecedor(codigoFornecedor);
                    if (fornecedor != null)
                    {
                        this.nomeFornecedorTextBox.Text = fornecedor.NomeFornecedor;
                    }

                }
            }
        }
    }
}
