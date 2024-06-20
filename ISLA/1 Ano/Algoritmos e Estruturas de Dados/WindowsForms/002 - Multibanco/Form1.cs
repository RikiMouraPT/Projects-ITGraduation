using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace _002___Multibanco
{
    public partial class FormMultibanco : Form
    {
        public FormMultibanco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bem-vindo ao Multibanco!", "Bem-Vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSaldo.Text = "500,00";

            lstMovimentos.View = View.Details;

            lstMovimentos.GridLines = true;
            lstMovimentos.Font = new Font("Akroma", 12, FontStyle.Regular);
            lstMovimentos.FullRowSelect = true;

            lstMovimentos.Columns.Add("#", 50);
            lstMovimentos.Columns.Add("Data", 195);
            lstMovimentos.Columns.Add("Movimento", 150);
            lstMovimentos.Columns.Add("Valor", 160);
            lstMovimentos.Columns.Add("Saldo", 160);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLevantar_Click(object sender, EventArgs e)
        {
            double saldo = Convert.ToDouble(txtSaldo.Text);
            double valor = Convert.ToDouble(txtValor.Text);

            if (valor > saldo)
            {
                MessageBox.Show("Saldo insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saldo -= valor;
                txtSaldo.Text = saldo.ToString("F2");

                string index = Convert.ToString(lstMovimentos.Items.Count + 1); // Cria um índice para a linha

                ListViewItem lista = new ListViewItem(index);

                lista.SubItems.Add(Convert.ToString(DateTime.Now)); // Adiciona a data
                lista.SubItems.Add("LEVANTAMENTO");                 // Adiciona o movimento
                lista.SubItems.Add(valor.ToString("C"));            // Adiciona o valor
                lista.SubItems.Add(saldo.ToString("C"));            // Adiciona o saldo

                lstMovimentos.Items.Add(lista);                     // Adiciona a linha à lista
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double saldo = Convert.ToDouble(txtSaldo.Text);
            double valor = Convert.ToDouble(txtValor.Text);

            saldo += valor;
            txtSaldo.Text = saldo.ToString("F2");

            string index = Convert.ToString(lstMovimentos.Items.Count + 1);
            ListViewItem lista = new ListViewItem(index);
            // string datahora = Convert.ToString(DateTime.Now);
            // lista.SubItems.Add(datahora.ToString("dd/mm/yyyy"));  // PARA PODER ESCOLHER O FORMATO
            lista.SubItems.Add(Convert.ToString(DateTime.Now));
            lista.SubItems.Add("DEPOSITO");
            lista.SubItems.Add(valor.ToString("C"));
            lista.SubItems.Add(saldo.ToString("C"));
            lstMovimentos.Items.Add(lista);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btnDepositar.Enabled = txtValor.Text.Length > 0;
            btnLevantar.Enabled = txtValor.Text.Length > 0;
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
