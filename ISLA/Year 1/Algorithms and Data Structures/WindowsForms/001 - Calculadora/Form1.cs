namespace _001___Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo/a à SUPER CALCULADORA!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Queres mesmo sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
            if (txtN1.Text == "" || txtN2.Text == "")
            {
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
            }
            else
            {
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnDividir.Enabled = true;
            }
            txtResultado.Text = "";
        }
        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            if (txtN1.Text == "" || txtN2.Text == "")
            {
                btnSomar.Enabled = false;
                btnSubtrair.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDividir.Enabled = false;
            }
            else
            {
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnDividir.Enabled = true;
            }
            txtResultado.Text = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtN1.Text);
                float num2 = Convert.ToSingle(txtN2.Text);

                float resultado = (float)num1 + (float)num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtN1.Text);
                float num2 = Convert.ToSingle(txtN2.Text);

                float resultado = (float)num1 - (float)num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtN1.Text);
                float num2 = Convert.ToSingle(txtN2.Text);

                float resultado = (float)num1 * (float)num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtN1.Text);
                float num2 = Convert.ToSingle(txtN2.Text);

                float resultado = (float)num1 / (float)num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}